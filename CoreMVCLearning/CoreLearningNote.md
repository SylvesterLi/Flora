# Connect to DataBase
//设置Context用于连接数据库（相当于一个数据库的实体）

//设置数据库的表 有哪些
```C#
public class MyDbContext:DbContext
{
    public DbSet<Music> Musics{get;set;}
}
```
//选择你要用什么数据库，告诉EF你的数据库钥匙（ConnectionString）
```C#
protected override void Configuring(DbContextOptionBuilder option)
{
    option.UseSqlite("Data Source=app.db");
}
```
## CRUD
```C#
public void CRUD()
{
    var dbContext=new MyDBContext();
    dbContext.Musics.Add(new Music
    {
        Title="asdasd",
        Time="asdasd"
    });
    //dbContext.update();
    dbContext.SaveChanges();
}
```
