using ECommerce.DataAcces.Context;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;
using ECommerce.Repository.DataAcces.EntityFrameWorkAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Concrete.EFEntityFramework;

public class EFCategoryDal : EFEntityRepositoryBase<Category, ECommerceDb>, ICategoryDal
{
    //cruddan basqa olan emeliyyatlar
    //bu bizde ef core ile isleyen ECommerceDb database inin Category tablenie access yaradir 
    //biznes logic gelir ve it need to acces for it ele bil ki o datani elde edmek veya crud    
    //edmek ucun burdada bizim mohtesem dataAccessLayer var ve bu acces layer neynir 
    //bunun ilk once base i bizim IEntityRepositoryden implement edir
    //odaki hecne CRUD a icaze verir , demeli bu crud ede biler implement interface edib amma
    //bu onu gelib hemde isleyeceyimiz yeni EFEntityRepositoryBase bu klassdan toredirik ve aftomatik o generic bir CRUD a sahib olur.Ve o bizneslogicler artiq eyer crud deyilse burda yazlir yeni burda acces isdenlirki men ele bisey ede bileremmi bilmeremmi
    // objim hecne burdanda gedir domaine classsi gotrur , burda contextim var onu da gotrur
    //gedirler repositorye eger cruddursa ve ya EFEntityRepositoryBase burdaki methoddursa
    //deyilsede hecne logic yazlir yeni accesder .

}
