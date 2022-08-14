namespace ToDo_Uygulamasi
{
    class Line
    {
        private int kolon; // 1-Todo | 2-inProgress | 3-Done
        private string baslik = "";
        private string icerik = "";
        private int kisiID;
        private int buyukluk;

        public int Kolon { get => kolon; set => kolon = value; }
        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public int KisiID { get => kisiID; set => kisiID = value; }
        public int Buyukluk { get => buyukluk; set => buyukluk = value; }
    }
}
