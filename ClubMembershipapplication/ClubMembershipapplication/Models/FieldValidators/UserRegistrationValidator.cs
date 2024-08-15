using FieldValidatorAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FieldValidatorAPI.CommondFieldValidator;

namespace ClubMembershipapplication.Models.FieldValidators
{
    public class UserRegistrationValidator : IFieldValidator
    {
        const int FirstName_Min_Lenght = 2;
        const int LastName_Min_Lenght = 2;
        const int FirstName_Max_Lenght = 100;
        const int LastName_Max_Lenght = 100;

        delegate bool EmailExist(string emailAddress);


        // delegates
        FieldValidatorDel _fieldValidatorDel = null;
        RequiredValidDel __requiredValidDel = null;
        StringLengValidDel _stringLengValidDel = null;
        DateValidDel _dateValidDel = null;
        PatterMatchValidDel _patterMatchValidDel = null;
        CompareFieldsValidDel _compareFieldsValidDel = null;
        EmailExist _emailExist = null;


        string[] _fieldArray = null;

        public string[] FieldArray
        {
            get
            {
                if (_fieldArray == null)
                    _fieldArray = new string[Enum.GetValues(typeof
                        (FieldConstants.UserRegistrationField)).Length];
                return _fieldArray;
            }   
        }

        public FieldValidatorDel ValidatorDel => _fieldValidatorDel;

        public string[] fieldArray => throw new NotImplementedException();

        public UserRegistrationValidator()
        {

        }

        public void InitialiseValidatorDelegate()
        {
            __requiredValidDel = CommonFieldValidatorFunctions.RequiredFieldValidDel;
            _stringLengValidDel = CommonFieldValidatorFunctions.StringFieldValidLenght;
            _dateValidDel = CommonFieldValidatorFunctions.DateFieldValidDel;
            _patterMatchValidDel = CommonFieldValidatorFunctions.PatternFieldValidDel;
            _compareFieldsValidDel = CommonFieldValidatorFunctions.CompareFieldValidDel;
           
        }

       
    }
}
