using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogBook.Models;

namespace LogBook.Repository;

public static class FakeRepository
{
    public static List<Student> students = new()
    {
        new(1,null,"Nihat","Ekremi Canbehan","Celal",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),
        new(2,null,"Tural","Haci-Nebili","Mahir",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),
        new(3,null,"Elshad","Hesenov","Salman",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),
        new(4,null,"Huseyn","Ibrahimov","Allahverdi",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),
        new(5,null,"Kamran","Kerimzade","Natiq",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),
        new(6,null,"Murad","Meherremli","Yusif",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),
        new(7,null,"Kenan","Muradov","Xalid",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),
        new(8,null,"Ali","Shamilzade","Azer",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),
        new(9,null,"Leyla","Shefiyeva","Dursun",new DateTime(2022,10,3),ParticipationStatus.Unknown,null,null,null,null),

    };
}
