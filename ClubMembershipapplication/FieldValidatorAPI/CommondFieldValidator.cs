using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static FieldValidatorAPI.CommondFieldValidator;

namespace FieldValidatorAPI
{
    public class CommondFieldValidator
    {
        public delegate bool RequiredValidDel(string fieldVal);
        public delegate bool StringLengValidDel(string fieldVal, int min, int max);
        public delegate bool DateValidDel(string fieldVal, out DateTime validDatetime);
        public delegate bool PatterMatchValidDel(string fieldVal, string pattern);
        public delegate bool CompareFieldsValidDel(string fieldVal, string fieldValCompare);
    }

    public class CommonFieldValidatorFunctions
    {
        private static RequiredValidDel _requiredValidDel = null;
        private static StringLengValidDel _stringLengValidDel = null;
        private static DateValidDel _dateValidDel = null;
        private static PatterMatchValidDel _patterMatchValidDel = null;
        private static CompareFieldsValidDel _compareFieldsValidDel = null;

        public static RequiredValidDel RequiredFieldValidDel
        {
            get
            {
                if (_requiredValidDel == null)
                    _requiredValidDel = new RequiredValidDel(RequiredFieldValid);
                return _requiredValidDel;

                
            }
        }

        public static StringLengValidDel StringFieldValidLenght
        {
            get
            {
                if (_stringLengValidDel == null)
                    _stringLengValidDel = new StringLengValidDel(StringFieldLenghtField);
                return _stringLengValidDel;


            }
        }

        public static DateValidDel DateFieldValidDel
        {
            get
            {
                if (_dateValidDel == null)
                    _dateValidDel = new DateValidDel(DateFieldValid);
                return _dateValidDel;


            }
        }

        public static PatterMatchValidDel PatternFieldValidDel
        {
            get
            {
                if (_patterMatchValidDel == null)
                    _patterMatchValidDel = new PatterMatchValidDel(PatterFieldValid);
                return _patterMatchValidDel;


            }
        }

        public static CompareFieldsValidDel CompareFieldValidDel
        {
            get
            {
                if (_compareFieldsValidDel == null)
                    _compareFieldsValidDel = new CompareFieldsValidDel(FieldComparisonValid);
                return _compareFieldsValidDel;


            }
        }



        // implements methods

        private static bool RequiredFieldValid(string fieldValid)
        {
            if (!string.IsNullOrEmpty(fieldValid))
            
                return true;
            return false;
        }

        private static bool StringFieldLenghtField(string fieldVal, int min, int max)
        {
            if (fieldVal.Length >= min && fieldVal.Length <= max)
                return true;
            return false;
        }

        private static bool DateFieldValid(string datetime,  out DateTime validDatetime)
        {
            if (DateTime.TryParse(datetime, out validDatetime))
                return true;
            return false;
        }


        private static bool PatterFieldValid(string fieldVal, string regularExpressionPattern)
        {
            Regex regex = new Regex(regularExpressionPattern);
            if (regex.IsMatch(fieldVal))
                return true;
            return false;
        }

        private static bool FieldComparisonValid(string fieldVal, string fieldValCompare)
        {
            if (fieldVal.Equals(fieldValCompare))
                return true;
            return false;
        }
    }
}
