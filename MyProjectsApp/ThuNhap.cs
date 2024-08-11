namespace MyApp{
    class ThuNhap : Entry, IEntry{
        #region Attributes
        private int salary;
        private int tro_cap;
        private int tien_khac;
        public static int Total_ThuNhap = 0;
        #endregion
        #region Getters and Setters
        public int Salary{
            get{return salary;}
            set{salary = value;}
        }

        public int Tro_cap{
            get{return tro_cap;}
            set{tro_cap = value;}
        }
        
        public int Tien_khac{
            get{return tien_khac;}
            set{tien_khac = value;}
        }
        #endregion
        #region Methods
        public void setTotal(){
            Total_ThuNhap += (Salary + Tro_cap + Tien_khac);
        }
        public int getTotal(){
            return Total_ThuNhap;
        }
        #endregion
    }
}