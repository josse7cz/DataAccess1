
using DataAccess1.Interface;


namespace DataAccess1.Model

{
    public class Receipt:IEntity
    {
        public virtual int Id { get; set; }
      
        public virtual int User_Id { get; set; }
       
        public virtual int Item_Id { get; set; }
        
    }
}