using System.Collections.Generic;
using System.Web.Mvc;

namespace AuthSystem.Manager
{
    public class AccountManager
    {
        public List<SelectListItem> lists()
        {
            List<SelectListItem> listItems = new List<SelectListItem>()
            {
                new SelectListItem(){Value = "1", Text = "Student"},
                new SelectListItem(){Value = "2", Text = "Teacher"}
            };
            return listItems;
        }
    }
}