using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTrr.Base
{
    internal class Help1
    {
        public Help1()
        {
        }
        private String valor = "'%;(-)º<>¿?*//\\ª!·$&=^¨¡`+´ç";
        private bool var = false;

        public bool valorRestringuido(char keyChar)
        {
            for (int i = 0; i < valor.Length; i++)
            {
                if (keyChar == valor[i] || keyChar == '"')
                {
                    var = true;
                    break;
                }
                else var = false;
            }
            return var;
        }

        public bool TelFormat(String text)
        {
            String nums = "0123456789";
            int va = 0;
            //MessageBox.Show("Pos 4"+ text[4].ToString());
            if (text[4].ToString() == "-")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i != 4)
                    {
                        for (int j = 0; j < nums.Length; j++)
                        {
                            if (text[i].ToString() == nums[j].ToString())
                            {
                                va = 1;
                                break;
                            }
                            //MessageBox.Show("Dato "+i+"\nNums"+j+"\ndatoTel "+ text[i].ToString()+"\nva "+va);
                        }
                        if (va == 0) break;
                        else va = 0;                        
                    }
                    if (i == text.Length - 1) va = 1;
                }
            }
            //MessageBox.Show("va "+va);
            if (va == 0) return false;
            else return true;            
        }
    }
}