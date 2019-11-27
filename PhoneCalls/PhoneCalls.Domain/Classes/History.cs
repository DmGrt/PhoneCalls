using System;
using System.Collections.Generic;

namespace PhoneCalls.Domain.Classes
{
    public class History
    {

        public List<Call> CallHistory = new List<Call>();
        public void AddToHist(Call call)
        {
            if (call != null)
                CallHistory.Add(call);
            else
                throw new ArgumentNullException($"call is null");
        }

    }
}
