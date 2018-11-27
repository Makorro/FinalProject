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

        public Store ReadQR(string name)
        {
            string imagePath = Utils.GetStoresPath() + name;
            Bitmap image = new Bitmap(imagePath);

            var data = _QRdecoder.ImageDecoder(image);
            string jsonObject = QRCode.ByteArrayToStr(data[0]);

            QRStore qrStore = JsonConvert.DeserializeObject<QRStore>(jsonObject);

            Store store = new Store(qrStore.idStore, qrStore.storeName);
            store.products = qrStore.products;
            image.Dispose();

            return store;
        }

        public void CreateQR(Store store)
        {
            string path = Utils.GetStoresPath() + store.storeName + ".png";
            string json = JsonConvert.SerializeObject(store);

            QRStore qrStore = new QRStore(store.idStore, store.storeName);
            qrStore.products = store.products;

            _QRencoder.Encode(ErrorCorrection.H, json);
            Bitmap QRStore = QRCodeToBitmap.CreateBitmap(_QRencoder, 4, 8);
             
            FileStream FS = new FileStream(path, FileMode.Create);
            QRStore.Save(FS, ImageFormat.Png);
            FS.Close();
        }
    }
}
