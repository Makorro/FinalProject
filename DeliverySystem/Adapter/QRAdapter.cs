using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCodeEncoderDecoderLibrary;
using System.Web.Script.Serialization;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Newtonsoft.Json;
using DeliverySystem.Adapter;

namespace DeliverySystem
{
    class QRAdapter
    {
        private QREncoder _QRencoder;
        private QRDecoder _QRdecoder;

        public QRAdapter()
        {
            _QRencoder = new QREncoder();
            _QRdecoder = new QRDecoder();
        }

        private List<Product> ConvertStoreProductListToProductList(List<StoreProduct> store_products)
        {
            List<Product> products = new List<Product>();
            Product product;

            foreach (StoreProduct store_product in store_products)
            {
                product = new Product();
                product.idProduct = store_product.idProduct;
                product.name = store_product.name;
                product.quantity = store_product.quantity;
                products.Add(product);
            }

            return products;
        }

        private List<StoreProduct> ConvertProductListToStoreProductList(List<Product> products)
        {
            List<StoreProduct> store_products = new List<StoreProduct>();

            foreach (Product product in products)
            {
                store_products.Add(new StoreProduct(product.idProduct, product.name, product.quantity));
            }

            return store_products;
        }

        public Store ReadQR(string name)
        {
            string imagePath = Utils.GetStoresPath() + name;
            Bitmap image = new Bitmap(imagePath);

            var data = _QRdecoder.ImageDecoder(image);
            string jsonObject = QRCode.ByteArrayToStr(data[0]);

            QRStore qrStore = JsonConvert.DeserializeObject<QRStore>(jsonObject);

            Store store = new Store(qrStore.idStore, qrStore.storeName);
            store.products = ConvertProductListToStoreProductList(qrStore.products);
            image.Dispose();

            return store;
        }

        public void CreateQR(Store store)
        {
            string path = Utils.GetStoresPath() + store.storeName + ".png";
            string json = JsonConvert.SerializeObject(store);

            QRStore qrStore = new QRStore(store.idStore, store.storeName);
            qrStore.products = ConvertStoreProductListToProductList(store.products);

            _QRencoder.Encode(ErrorCorrection.H, json);
            Bitmap QRStore = QRCodeToBitmap.CreateBitmap(_QRencoder, 4, 8);
             
            FileStream FS = new FileStream(path, FileMode.Create);
            QRStore.Save(FS, ImageFormat.Png);
            FS.Close();
            Logger.Log(String.Format("Image succesfully created for store: {0}", qrStore.storeName));
        }
    }
}
