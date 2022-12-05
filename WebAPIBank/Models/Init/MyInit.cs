using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;
using WebAPIBank.Models.Context;
using WebAPIBank.Models.Entites;

namespace WebAPIBank.Models.Init
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            CardInfo cardInfo = new CardInfo();
            cardInfo.CardUserName = "Oktay Dak";
            cardInfo.CardNumber = "1111 1111 1111 1111";
            cardInfo.CardExpiryYear = 2028;
            cardInfo.CardExpiryMonth = 10;
            cardInfo.SecurityNumber = "111";
            cardInfo.Limit = 500000;
            cardInfo.Balance = 5000000;
            context.Cards.Add(cardInfo);
            context.SaveChanges();

        }
    }
}