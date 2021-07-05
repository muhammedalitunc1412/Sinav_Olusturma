using SınavOluşturma.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOluşturma.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
    }
}
