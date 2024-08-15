using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipapplication.Models.FieldValidators
{
    public delegate bool FieldValidatorDel(int fieldIndex,
        string fieldValue, string[] fieldArray, out string fieldInvalidMessage);
    public interface IFieldValidator
    {
        void InitialiseValidatorDelegate();
        string[] fieldArray { get;}
        FieldValidatorDel ValidatorDel { get; }
    }
}
