using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }

    public partial class Form1 : Form
    {
        // 建立一個汽車清單作為欄位，用來儲存所有輸入的汽車資料
        private List<Automobile> carList = new List<Automobile>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetData 方法會取得使用者在文字方塊中輸入的資料，
        // 並將這些資料指派給傳入參數 auto 的各個欄位
        private void GetData(ref Automobile auto)
        {
            try
            {
                // 從各個文字方塊取得使用者輸入的資料，並轉換成對應的型別
                auto.make = makeTextBox.Text;
                auto.year = int.Parse(yearTextBox.Text);
                auto.mileage = double.Parse(mileageTextBox.Text);
            }
            catch (Exception ex)
            {
                // 若發生例外，顯示例外訊息（以繁體中文顯示）
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // 建立一個 Automobile 結構的實例，用來儲存單一汽車資料
            Automobile car = new Automobile();

            // 取得使用者輸入的汽車資料，並存入 car 物件
            GetData(ref car);

            // 將 car 物件加入汽車清單 carList 中
            carList.Add(car);

            // 清空所有文字方塊，方便使用者繼續輸入下一筆資料
            makeTextBox.Clear();
            yearTextBox.Clear();
            mileageTextBox.Clear();

            // 將游標焦點設回 makeTextBox，提升使用者體驗
            makeTextBox.Focus();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // 宣告一個字串變數 output，用來儲存每一行要顯示的汽車資訊
            string output;

            // 清除 ListBox 目前的所有內容，避免重複顯示
            carListBox.Items.Clear();

            // 逐一將汽車清單中的每一筆資料格式化後顯示在 ListBox 上
            foreach (Automobile aCar in carList)
            {
                // 將汽車的年份、廠牌與里程數組合成一行資訊（以繁體中文顯示）
                output = aCar.year + " 年 " + aCar.make +
                    "，里程數：" + aCar.mileage + " 英里。";

                // 將格式化後的資訊加入 ListBox 顯示
                carListBox.Items.Add(output);
            }
        }
    }
}
