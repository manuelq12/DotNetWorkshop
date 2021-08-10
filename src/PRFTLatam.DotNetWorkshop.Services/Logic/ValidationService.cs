using System;
using System.Collections.Generic;
using PRFTLatam.DotNetWorkshop.Services.Model;

namespace PRFTLatam.DotNetWorkshop.Services.Logic
{
    public class ValidationService{

        private Identification id;
        private Notification notification;

        public ValidationService(){
            this.id = new Identification("");
            this.notification = new Notification();
        }

        public void SetIdentification(String id){
            this.id.setIdentification(id);
        }

        public Notification GetNotification(){
            return this.notification;
        }
        
        public List<String> ValidateIdentification(){
            if(id.IsNullOrEmptyIdentifier()){
                notification.AddError(ValidationMessage.NullOrEmptyError);
                return notification.GetErrors();
            }

            if(!id.isAtLeastTenCharacters()){
                notification.AddError(ValidationMessage.MinimumLengthError);
            }

            if(!id.isAtMostThirtyTwoCharacters()){
                notification.AddError(ValidationMessage.MaximumLengthError);
            }

            if(id.IsHexadecimal()){
                notification.AddError(ValidationMessage.NoHexadecimalNumber);
            }

            return notification.GetErrors();
        }
    }
}
