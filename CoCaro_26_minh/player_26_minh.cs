using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCaro_26_minh
{
    public class Player_26_minh
    {
        private string name_26_minh;
        public string Name_26_minh { get => name_26_minh; set => name_26_minh = value; }
       

        private Image mark_26_minh;
        private Image avt_26_minh;
        public Image Mark_26_minh { get => mark_26_minh; set => mark_26_minh = value; }
        public Image Avt_26_minh { get => avt_26_minh; set => avt_26_minh = value; }

        public Player_26_minh(string name_26_minh,Image mark_26_minh,Image avt_26_minh) 
        { 
            this.Name_26_minh = name_26_minh;
            this.Mark_26_minh = mark_26_minh;   
            this.Avt_26_minh = avt_26_minh;
        }
    }
}
