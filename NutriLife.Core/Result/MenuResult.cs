using NutriLife.Core.Domain;
using System;
using System.Collections.Generic;

namespace NutriLife.Core.Result
{
    public class MenuResult: Base
    { 
        public MenuResult()
        {
            CreateItens();
        }              

        public MenuResult(DateTime dateTime, Person person)
        {
            CreateItens();
            DateTime = dateTime;
            Person = person;
        }

        public DateTime DateTime { get; private set; }
        public Person Person { get; private set; }
        public IList<Menu> MenuItens { get; private set; }  

        public void AddMenuItem(Menu menu)
        {
            MenuItens.Add(menu);
        }

        public void AddMenuList(IList<Menu> listmenu)
        {
            ((List<Menu>)MenuItens).AddRange(listmenu);           
        }

        private void CreateItens()
        {
            if (MenuItens == null)
            {
                MenuItens = new List<Menu>();
            }
        }
    }
}