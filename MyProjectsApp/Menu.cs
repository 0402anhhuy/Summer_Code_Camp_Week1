using System.Security.Cryptography.X509Certificates;
namespace MyApp{
    class Menu{
        #region Attributes
        private int option;
        public List<KeyValuePair<string, ThuNhap>> ds_thu_nhap = new List<KeyValuePair<string, ThuNhap>>();
        public List<KeyValuePair<string, ChiTieu>> ds_chi_tieu = new List<KeyValuePair<string, ChiTieu>>();
        #endregion
        public void display(){
            while(true){
                ThuNhap thu_nhap = new ThuNhap();
                ChiTieu chi_tieu = new ChiTieu();
                Menu_ThuNhap Menu_ThuNhap = new Menu_ThuNhap();
                Menu_ChiTieu Menu_ChiTieu = new Menu_ChiTieu();
                Console.WriteLine("\n---------------MENU---------------");
                Console.WriteLine("1. Thêm giao dịch mới");
                Console.WriteLine("2. Hiện thị các khoản chi tiêu");
                Console.WriteLine("3. Hiện thị các khoản thu nhập");
                Console.WriteLine("4. Kết thúc chương trình");
                Console.Write("Nhập lựa chọn của bạn: ");
                option = int.Parse(Console.ReadLine());
                switch(option){
                    case 1:
                        // Create a new instance of Entry class
                        Entry entry = new Entry();
                        entry.input_Type();
                        if(entry.Type == "Thu nhap"){
                            // Create a new instance of Menu_ThuNhap class and ThuNhap class
                            Menu_ThuNhap.display_thu_nhap();
                            int choice = Menu_ThuNhap.getChoice();
                            entry.input_Money(); thu_nhap.Money = entry.Money;
                            entry.input_Date(); thu_nhap.Date = entry.Date;
                            switch(choice){
                                // Set tiền cho từng danh mục dùng để tính tổng thu nhập
                                case 1:
                                    thu_nhap.Salary = entry.Money;
                                    ds_thu_nhap.Add(new KeyValuePair<string, ThuNhap>("Tiền lương", thu_nhap));
                                    break;
                                case 2:
                                    thu_nhap.Tro_cap = entry.Money;
                                    ds_thu_nhap.Add(new KeyValuePair<string, ThuNhap>("Trợ cấp", thu_nhap));
                                    break;
                                case 3:
                                    thu_nhap.Tien_khac = entry.Money;
                                    ds_thu_nhap.Add(new KeyValuePair<string, ThuNhap>("Tiền khác", thu_nhap));
                                    break;
                            }
                            thu_nhap.setTotal();
                        }
                        else if(entry.Type == "Chi tieu"){
                            // Create a new instance of ChiTieu class and Menu_ChiTieu class
                            Menu_ChiTieu.display_chi_tieu();
                            int choice = Menu_ChiTieu.getChoice();
                            entry.input_Money(); chi_tieu.Money = entry.Money;
                            entry.input_Date(); chi_tieu.Date = entry.Date;
                            switch(choice){
                                // Set tiền cho từng danh mục dùng để tính tổng chi tiêu
                                case 1:
                                    chi_tieu.Tien_tro = entry.Money;
                                    ds_chi_tieu.Add(new KeyValuePair<string, ChiTieu>("Tiền trọ", chi_tieu));
                                    break;
                                case 2:
                                    chi_tieu.Tien_dien_nuoc = entry.Money;
                                    ds_chi_tieu.Add(new KeyValuePair<string, ChiTieu>("Tiền điện, nước", chi_tieu));
                                    break;
                                case 3:
                                    chi_tieu.Tien_mang = entry.Money;
                                    ds_chi_tieu.Add(new KeyValuePair<string, ChiTieu>("Tiền Internet", chi_tieu));
                                    break;
                                case 4:
                                    chi_tieu.Tien_an_uong = entry.Money;
                                    ds_chi_tieu.Add(new KeyValuePair<string, ChiTieu>("Tiền ăn uống", chi_tieu));
                                    break;
                                case 5:
                                    chi_tieu.Tien_di_lai = entry.Money;
                                    ds_chi_tieu.Add(new KeyValuePair<string, ChiTieu>("Tiền đi lại", chi_tieu));
                                    break;
                                case 6:
                                    chi_tieu.Hoc_phi = entry.Money;
                                    ds_chi_tieu.Add(new KeyValuePair<string, ChiTieu>("Học phí", chi_tieu));
                                    break;
                                case 7:
                                    chi_tieu.Tien_khac = entry.Money;
                                    ds_chi_tieu.Add(new KeyValuePair<string, ChiTieu>("Chi phí khác", chi_tieu));
                                    break;
                            }
                            chi_tieu.setTotal();
                        }
                        break;
                    case 2: 
                        int res_ChiTieu = Menu_ChiTieu.getTotal();
                        Console.WriteLine("\nChi tiêu");
                        Menu_ChiTieu.display_Budget();
                        Console.WriteLine("ID       Loại chi tiêu                          Số tiền                         Ngày, Tháng, Năm");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        int ID_1 = 1;
                        foreach(var x in ds_chi_tieu){
                            Console.WriteLine($"{ID_1++, -7}   {x.Key, -35}   {x.Value.Money, 7}   {x.Value.Date, 34}");
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"Tổng                                   {res_ChiTieu, 16}\n");
                        break;
                    case 3:
                        int res_ThuNhap = Menu_ThuNhap.getTotal();
                        Console.WriteLine("\nThu nhập");
                        Console.WriteLine("ID       Loại thu nhập                          Số tiền                         Ngày, Tháng, Năm");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        int ID_2 = 1;
                        foreach(var x in ds_thu_nhap){
                            Console.WriteLine($"{ID_2++, -7}   {x.Key, -35}   {x.Value.Money, 7}   {x.Value.Date, 34}");
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"Tổng                                   {res_ThuNhap, 16}\n");
                        break;
                    case 4:
                        Console.WriteLine("Kết thúc chương trình");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                        break;
                }
            }
        }
    }
}