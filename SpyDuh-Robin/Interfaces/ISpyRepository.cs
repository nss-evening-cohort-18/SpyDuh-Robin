﻿using SpyDuh_Robin.Models;

namespace SpyDuh_Robin.Interfaces
{
    public interface ISpyRepository
    {
        void Post(Spy spy);

        List<Spy> GetAll();

        List<Spy> GetBySkill(string skill);
        List<Spy> GetByFriend(int friend);
        List<Spy> GetByEnemy(int enemy);

        List<Spy> GetByFriendofFriend(int friend);

        void AddSkill(int id, List<string> value);

        void AddService(int id,List<string> value);
    }

}
