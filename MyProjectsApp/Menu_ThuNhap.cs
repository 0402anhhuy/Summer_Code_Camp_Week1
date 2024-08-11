using System.Xml.Serialization;
namespace MyApp{
    class Menu_ThuNhap : ThuNhap{
        #region Attributes
        private int choice;
        #endregion
        #region Getters and Setters
        public int getChoice(){
            return choice;
        }
        #endregion
        #region Methods
        public void display_thu_nhap(){
            Console.WriteLine("\nDanh sách loại thu nhập:");
            Console.WriteLine("   1. Lương");
            Console.WriteLine("   2. Trợ cấp");
            Console.WriteLine("   3. Thu nhập khác");
            Console.Write("Chọn loại thu nhập: ");
            while(true){
                choice = int.Parse(Console.ReadLine());
                if(choice > 3){
                    Console.Write("Lựa chọn không hợp lệ. Vui lòng chọn lại: ");
                }
                else break;
            }
        }
        #endregion
    }
}