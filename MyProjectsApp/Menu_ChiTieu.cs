using System.Security.Cryptography.X509Certificates;
namespace MyApp{
    class Menu_ChiTieu : ChiTieu{
        #region Attributes
        private int choice;
        private int budget;
        #endregion
        #region Getters and Setters
        public int getChoice(){
            return choice;
        }
        #endregion
        #region Methods
        public void display_chi_tieu(){
            Console.WriteLine("\nDanh sách loại chi tiêu:");
            Console.WriteLine("   1. Tiền trọ");
            Console.WriteLine("   2. Tiền điện, nước");
            Console.WriteLine("   3. Tiền Internet");
            Console.WriteLine("   4. Tiền ăn uống");
            Console.WriteLine("   5. Tiền đi lại");
            Console.WriteLine("   6. Học phí");
            Console.WriteLine("   7. Chi phí khác");
            Console.Write("Chọn loại chi tiêu: "); 
            while(true){
                choice = int.Parse(Console.ReadLine());
                if(choice > 7){
                    Console.Write("Lựa chọn không hợp lệ. Vui lòng chọn lại: ");
                }
                else break;
            }
        }
        public void display_Budget(){
            ThuNhap thu_nhap = new ThuNhap();
            ChiTieu chi_tieu = new ChiTieu();
            budget = thu_nhap.getTotal();
            budget -= chi_tieu.getTotal();
            Console.WriteLine("Ngân sách: {0}", budget);
            if(budget <= 2000000 && budget > 0){
                Console.WriteLine("Bạn đã gần đạt giới hạn của ngân sách!!!");
            }
        }
        #endregion
    }
}