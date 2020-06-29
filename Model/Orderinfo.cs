using System;

namespace _Netcore_practice.Models{
    public class Orderinfo
    {
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string ResellerNo { get; set; }
        public Orderinfo()
        {
            OrderNo = string.Empty;
            OrderDate = DateTime.MinValue;
            ResellerNo = string.Empty;
        }
        public Orderinfo(string orderNo, DateTime orderDate, string resellerNo)
        {
            OrderNo = orderNo;
            OrderDate = orderDate;
            ResellerNo = resellerNo;
        }
        public override string ToString()
        {
            return $"OrderNo:{OrderNo}, OrderDate:{OrderDate}, Reseller_No:{ResellerNo}.";
        }
    }
}