using System;
using System.Collections.Generic;
using PRFTLatam.DotNetWorkshop.Services.Model;
using PRFTLatam.DotNetWorkshop.Services.Util;

namespace PRFTLatam.DotNetWorkshop.Services.Logic
{
    public class ValidationService{

        private Identification id;
        private Notification notification;

        private FileReader fileReader;

        public ValidationService(){
            this.id = new Identification("");
            this.notification = new Notification();
            this.fileReader = new FileReader();
            this.fileReader.ReadCSV();
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

            if(!id.IsAtLeastTenCharacters()){
                notification.AddError(ValidationMessage.MinimumLengthError);
            }

            if(!id.IsAtMostThirtyTwoCharacters()){
                notification.AddError(ValidationMessage.MaximumLengthError);
            }

            if(id.IsHexadecimal()){
                notification.AddError(ValidationMessage.NoHexadecimalNumber);
            }

            if(!id.IsOnTheWhitelist(this.fileReader.GetWhitelistIds())){
                notification.AddError(ValidationMessage.IdentificationNotFoundOnCSV);
            }
            
            return notification.GetErrors();
        }
    }
}
