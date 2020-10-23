using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMS.Persistance;
using TMS.Project.Data;


namespace TMS.Service
{
  public  class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return this._unitOfWork.UserRepository.GetAll();

        }
        public User  GetByID(int id)
        {
            return this._unitOfWork.UserRepository.GetByid(id);

        }
        public User GetByEmail(string email)
        {
            return this._unitOfWork.UserRepository.FirstOrDefault(x =>x.Email==email);

        }
        public int AddUser(User user)
        {
             this._unitOfWork.UserRepository.Add(user);
            this._unitOfWork.Save();   
            return user.Id;

        }
    }

}
