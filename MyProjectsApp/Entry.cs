namespace MyApp{
    class Entry{
        #region Attributes
        private int money;

        // Loại thu nhập hoặc chi tiêu
        private string type = "";
        private string date = "";
        #endregion
        #region Getters and Setters
        public int Money{
            get{return money;}
            set{money = value;}
        }
        public string Type{
            get{return type;}
            set{type = value;}
        }
        public string Date{
            get{return date;}
            set{date = value;}
        }
        #endregion
        #region Methods
        virtual public void display_Type(){
            Console.WriteLine("Loại: {0}", Type);
        }
        virtual public void display_Money(int money){
            money = Money;
            Console.WriteLine("Số tiền: {0}", money);
        }
        virtual public void display_Date(){
            Console.WriteLine("Ngày: {0}", Date);
        }
        #endregion
        #region Input
        public void input_Type(){
            Console.Write("Chọn loại giao dịch (Chi tiêu/Thu nhập): ");
            Type = Console.ReadLine()?.ToString() ?? string.Empty;
        }
        public void input_Money(){
            Console.Write("Nhập số tiền: ");
            Money = int.Parse(Console.ReadLine());
        }
        public void input_Date(){
            Console.Write("Nhập ngày, tháng, năm giao dịch: ");
            Date = Console.ReadLine()?.ToString() ?? string.Empty;
        }
        #endregion
    }
}