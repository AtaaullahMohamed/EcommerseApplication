﻿using EcommerseApplication.Models;

namespace EcommerseApplication.Repository
{
    public class UserPayementRespository : IUserPayement
    {
        private readonly Context context;

        public UserPayementRespository(Context _con)
        {
            context = _con;
        }

        public void AddUSerPayment(User_Payement newPaement)
        {
            context.User_Payements.Add(newPaement);
            context.SaveChanges();
        }

        public void DeleteUserPayment(int id)
        {
            context.User_Payements.Remove(GetUserPayment(id));
        }

        public User_Payement GetUserPayment(int id)
        {
            return context.User_Payements.FirstOrDefault(i => i.Id == id);
        }

        public void updateUserPayement(int id, User_Payement newPaement)
        {
            User_Payement user_Payementold =GetUserPayment(id);
            user_Payementold.Id =newPaement.Id;
            user_Payementold.PayementType = newPaement.PayementType;
            user_Payementold.AccountNo = newPaement.AccountNo;
            user_Payementold.Expiry = newPaement.Expiry;
            user_Payementold.Provider = newPaement.Provider;
            context.SaveChanges();
        }
    }
}
