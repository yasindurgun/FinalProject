using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        //mesaj ve işlem sonucu zaten IResult sayesinde gelecek biz sadece datayı belirticez
        T Data { get; }
    }
}
