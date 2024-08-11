namespace MyApp{
    class ChiTieu : Entry, IEntry{
        #region Attributes
        private int tien_tro;
        private int tien_dien_nuoc;
        private int tien_mang;
        private int tien_an_uong;
        private int tien_di_lai;
        private int hoc_phi;
        private int tien_khac;
        public static int Total_ChiTieu = 0;
        #endregion
        #region Getters and Setters
        public int Tien_tro{
            get{return tien_tro;}
            set{tien_tro = value;}
        }

        public int Tien_dien_nuoc{
            get{return tien_dien_nuoc;}
            set{tien_dien_nuoc = value;}
        }

        public int Tien_mang{
            get{return tien_mang;}
            set{tien_mang = value;}
        }

        public int Tien_an_uong{
            get{return tien_an_uong;}
            set{tien_an_uong = value;}
        }

        public int Tien_di_lai{
            get{return tien_di_lai;}
            set{tien_di_lai = value;}
        }

        public int Hoc_phi{
            get{return hoc_phi;}
            set{hoc_phi = value;}
        }

        public int Tien_khac{
            get{return tien_khac;}
            set{tien_khac = value;}
        }
        #endregion
        #region Methods
        public void setTotal(){
            Total_ChiTieu += (Tien_tro + Tien_dien_nuoc + Tien_mang + Tien_an_uong + Tien_di_lai + Hoc_phi + Tien_khac);
        }
        public int getTotal(){
            return Total_ChiTieu;
        }
        #endregion
    }
}