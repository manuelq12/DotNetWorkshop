using System;

namespace PRFTLatam.DotNetWorkshop.Services.Model
{
    public class Identification
    {
        private string id;

        public Identification(string id){
            this.id = id;
        }

        public String getIdentification(){ return id;}
        public void setIdentification(string id){ this.id = id;}
        public bool IsNullOrEmptyIdentifier(){
            return string.IsNullOrEmpty(this.id) || string.IsNullOrWhiteSpace(this.id);
        }
        public bool isAtLeastTenCharacters(){
            return this.id.Length >=10;
        }
        public bool isAtMostThirtyTwoCharacters(){
            return this.id.Length <= 32;
        }
        public bool IsHexadecimal(){
            string upperCaseId = this.id.ToUpper();
            return upperCaseId.IndexOfAny(IdentificationConstraints.NotHexadecimalCharacters) != -1;
        }
    }
}
