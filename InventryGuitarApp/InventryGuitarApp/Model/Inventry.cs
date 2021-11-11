using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventryGuitarApp.Model.Enum;

namespace InventryGuitarApp.Model
{
    class Inventry
    {
        List<Guitar> listGuitar;

        public Inventry()
        {
            listGuitar = new List<Guitar>();
        }
        public void AddGuitar(string serielNumber, double price, Builder builder, string model, GType type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serielNumber, price, builder, model, type, backWood, topWood);
            listGuitar.Add(guitar);
        }

        public Guitar GetGuitar(string serielNumber)
        {
            foreach (Guitar guitar in listGuitar)
            {
                if (guitar.GetSerielNumber == serielNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(Guitar searchGuitar)
        {
            List<Guitar> mathGuitars = new List<Guitar>();
            foreach (Guitar items in listGuitar)
            {
                int flag = 0;
                Builder builder = searchGuitar.GetBuilder;
                String model = searchGuitar.GetModel;
                GType type = searchGuitar.GetType;
                Wood topWood = searchGuitar.GetTopWood;
                Wood backWood = searchGuitar.GetBackWood;
                if ((builder.Equals(items.GetBuilder)))
                {
                    flag = 1;
                }
                else if ((model.Equals(items.GetModel)))
                {
                    flag = 1;
                }
                else if ((type.Equals(items.GetType)))
                {
                    flag = 1;
                }
                else if ((topWood.Equals(items.GetTopWood)))
                {
                    flag = 1;
                }
                else if ((backWood.Equals(items.GetBackWood)))
                {
                    flag = 1;
                }
                else
                {
                    continue;
                }

                /*else if( model.Equals(" ") && model != null && !(model.Equals(items.GetModel)) )
                {
                    flag = 0;
                    break;
                }
                
                else if (type.Equals(" ") && type != null && !(type.Equals(items.GetType)))
                {
                    break;
                }
                
                else if (topWood.Equals(" ") && (topWood != null) && !(topWood.Equals(items.GetTopWood)))
                {
                    break;
                }
                
                else if (backWood.Equals(" ") && backWood != null && !(backWood.Equals(items.GetBackWood)))
                {
                    break;
                }*/

                if (flag == 1)
                {
                    mathGuitars.Add(items);
                }
                else
                {
                    continue;
                }
            }

            return mathGuitars;
        }

    }
}
