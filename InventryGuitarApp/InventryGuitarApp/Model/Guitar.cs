using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventryGuitarApp.Model;
using InventryGuitarApp.Model.Enum;

namespace InventryGuitarApp.Model
{
    class Guitar
    {
        private string _serielNumber;
        private double _price;
        private Builder _builder;
        private string _model;
        private GType _type;
        private Wood _backWood;
        private Wood _topWood;

        public Guitar(string serielNumber, double price, Builder builder, string model, GType type, Wood backWood, Wood topWood )
        {
            this._serielNumber = serielNumber;
            this._price = price;
            this._builder = builder;
            this._model = model;
            this._type = type;
            this._backWood = backWood;
            this._topWood = topWood;
        }
        
        public string GetSerielNumber
        {
            get { return _serielNumber; }
        }
        public double GetPrice
        {
            get { return _price; }
        }
        public Builder GetBuilder
        {
            get { return _builder; }
        }
        public string GetModel
        {
            get { return _model; }
        }
        public GType GetType
        {
            get { return _type; }
        }
        public Wood GetBackWood
        {
            get { return _backWood; }
        }
        public Wood GetTopWood
        {
            get { return _topWood; }
        }
    }
}
