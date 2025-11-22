using Domain.Models;
using GUIForms.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW;

namespace Services
{
    public class LoadingLogic
    {
        private readonly Usingnumber _NO;
        private readonly Getcentralaizes GC;
        private readonly Unitofwork _IUW;
        private readonly product Pro;

        public LoadingLogic()
        {
            _NO = new Usingnumber();
            GC = new Getcentralaizes();
            _IUW = new Unitofwork(new EasyposEntities());
            Pro = new product();
        }

        public List<item> GetItems()
        {
            return GC.Getitemdatalist();
        }

        public BindingList<ItemRow> CreateItemRowsList()
        {
            return new BindingList<ItemRow>();
        }
    }

}
