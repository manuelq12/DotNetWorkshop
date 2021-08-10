using System;
using System.Collections.Generic;



namespace PRFTLatam.DotNetWorkshop.Services.Model
{
    public class Notification{
        private List<String> errors;

        public Notification(){
            this.errors = new List<String>();
        }

        public List<String> GetErrors(){
            return this.errors;
        }

        public void AddError(String message){
            this.errors.Add(message);
        }

        public Boolean HasErrors(){
            return this.errors.Count > 0;
        }

        public void ResetNotifications(){
            this.errors = new List<String>();
        }
    }
}
