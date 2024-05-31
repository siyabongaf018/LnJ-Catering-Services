
/* 	Database name = "LnJ";
	Server name = (LocalDB)\MSSQLLocalDB;
	Data source = Microsoft SQL Server (SqlClient);
	Connection string = Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LnJ;Integrated Security=True;
*/
create database LnJ;
use LnJ;
/*CREATE TABLE [dbo].[tblDish] (
    [DishID]        INT          IDENTITY (1, 1) NOT NULL,
    [DishImagePath] VARCHAR (50) NOT NULL,
    [DishName]      VARCHAR (50) NOT NULL,
    [DishRating]      VARCHAR (50) NOT NULL,
    [DishPrice]     FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([DishID] ASC)
);*/
CREATE TABLE [dbo].[tblOrder]
(
	[OrderId] INT NOT NULL IDENTITY(124, 1),
	[MenuID] INT NULL, 
    [UsersId] INT NULL, 
	[UserAddress] VARCHAR(500) NOT NULL, 
	PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

CREATE TABLE [dbo].[tblUsers] (
    [UsersId]  INT          IDENTITY (100, 1) NOT NULL,
    [Name]     VARCHAR (50) NULL,
    [Surname]  VARCHAR (50) NULL,
    [Email]    VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL,
    [UserType] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([UsersId] ASC)
);

CREATE TABLE [dbo].[tblMenu] (
    [MenuID]          INT           IDENTITY (1, 1) NOT NULL,
    [MenuImagePath]   VARCHAR (50)  NOT NULL,
    [MenuName]        VARCHAR (50)  NOT NULL,
    [MenuRating]        VARCHAR (50)  NOT NULL,
    [MenuDescription] VARCHAR (1000) NOT NULL,
    [MenuPrice]       FLOAT (53)    NOT NULL,
	[Category]       VARCHAR (50)    NOT NULL DEFAULT 'Menu',
    PRIMARY KEY CLUSTERED ([MenuID] ASC)
);

CREATE TABLE [dbo].[tblReview] (
    [ReviewId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50)  NULL,
    [Surname]  VARCHAR (50)  NULL,
    [Review]   VARCHAR (1000) NULL,
    [Rating]   VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([ReviewId] ASC)
);

CREATE TABLE [dbo].[Cart] (
    [CartID]  INT IDENTITY (1, 1) NOT NULL,
    [MenuID]  INT NOT NULL,
    [UsersId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([CartID] ASC),
    FOREIGN KEY ([MenuID]) REFERENCES [dbo].[tblMenu] ([MenuID]),
    FOREIGN KEY ([UsersId]) REFERENCES [dbo].[tblUsers] ([UsersId])
);


INSERT INTO tblUsers VALUES('Tshiamo','Monageng','snow@admin.com','202cb962ac59075b964b07152d234b70','Admin');
INSERT INTO tblUsers VALUES('Siyabonga','Chibi','cya@admin.com','202cb962ac59075b964b07152d234b70','Admin');
INSERT INTO tblUsers VALUES('Deborah','Darkey','deborah@admin.com','202cb962ac59075b964b07152d234b70','Admin');
INSERT INTO tblUsers VALUES('Tshiamo','Monageng','snow@gmail.com','202cb962ac59075b964b07152d234b70','User');
INSERT INTO tblUsers VALUES('Siyabonga','Chibi','cya@gmail.com','202cb962ac59075b964b07152d234b70','User');
INSERT INTO tblUsers VALUES('Deborah','Darkey','deborah@gmail.com','202cb962ac59075b964b07152d234b70','User');


INSERT INTO tblMenu VALUES('images/menu-10.jpg','Banku and tilapia','5','When you see fish being grilled on the streets of Accra it is most likely to be tilapia, a 
delicacy among Ghanaians, who spice then grill the succulent freshwater fish.',74.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-11.jpg','Jollof Rice','5','Jollof is a pot dish of rice prepared with tomato sauce and served with meat or fish 
that stirs up plenty of interesting debate online.',64.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-12.jpg','Kelewele with pepper','5','Kelewele is an instant favourite among anyone who tries it, even those who aren’t big fans 
of peppery food. Usually sold as a snack or side dish all over Accra',54.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-13.jpg','Beans with fried plantain','5','Beans with fried plantain is a filling traditional dish that consists of cowpea beans boiled to 
make a broth, served with palm oil and soft, fried plantains.',34.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-14.jpg','kenkey with pepper and fried hake fish','5','This beautiful pan-fried hake recipe by Pascal Aussignac includes a red pepper relish and is a 
fantastic dish for the summer..',84.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-15.jpg','Waakye','5','Waakye is another food that exhibits Ghanaians’ creative use of rice. The recipe is a medley 
of beans and rice and was originally a Northern dish.',64.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-16.jpg','Fufu with light Soup/','5','. Ghanaian Fufu is commonly made by “pounding” cassava and 
unripe plantains together into a paste, which is then molded by hand into a ball shape and 
served with a special sauce/soup',74.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-17.jpg','Rice Balls with peanut butter Soup','5','Experience authentic West African cuisine in your own kitchen with this delicious Ghanaian 
palmnut and peanut butter soup recipe.',59.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-18.jpg','Fried Rice','5','Fried Rice is a combination of long grained rice, mixture of warm peas, carrots and onions 
with scrambled eggs mixed all together! You will not be getting take out any longer!.',12.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-19.jpg','Tuo Zaafi','5','Northern Ghanaian food is dominated by the use of grains, herbs and meat as these are the 
main food products of the area.',69.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-20.jpg','Fufu and goat light soup','5','Fufu is a staple food across West Africa 
but in Ghana, it is made by pounding a mixture of boiled cassava and plantains into a soft 
sticky paste to go along with aromatic and spicy tomato soup.',49.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-21.jpg','Yam with spinach Stew','5','The dish is called Kontomire, it is typically made from cocoyam leaves but you can substitute spinach.',59.99,DEFAULT);

INSERT INTO tblMenu VALUES('images/menu-22.jpg','Boiled yam or plantain with Kontomire stew ','5','One present feature in local Ghanaian food is the use of a variety of leaf vegetables and local herbs and spices.',49.99,DEFAULT);


INSERT INTO tblMenu VALUES('images/menu-01.jpg','Kenkey','5','Fermented maize dough is steamed while wrapped in banana leaves.',12.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-02.jpg','Kontomire Stew','5','Spinach or cocoyam soup along with fish or meat and spices. Gari, plantain, or plain rice nicely complement the dish.',24.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-04.jpg','Kelewele','4','The crispy fries are sweet and spicy, while the exterior has a crunchy texture, the interior is really soft, blessing you with the pleasure of sweetness.',22.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-05.jpg','Suya','5','Barbecued meats after they are marinated with spices.',2.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-06.jpg','Tuo Zaafi','5','The mingling of dried cassava and maize requires some hearty soup alongside to be enjoyed.',32.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-07.jpg','Apapransa','2','Palm nut and cornmeal soup cooked together to result in a solid chunk piece.',25.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-08.jpg','Red Red','5','Black-eyed peas cooked with tomatoes, ginger, and garlic.',22.99,DEFAULT);
INSERT INTO tblMenu VALUES('images/menu-09.jpg','Ampesi','1','A platter consisting of cassava, cocoyam, yam, plantain, and potatoes, all boiled, is called ampesi.',42.99,DEFAULT);

INSERT INTO tblMenu VALUES('images/dish-1.jpeg','Tasty Food','4','Dish',12.99,'Dish');
INSERT INTO tblMenu VALUES('images/dish-2.jpeg','Tasty Food','4','Dish',24.99,'Dish');
INSERT INTO tblMenu VALUES('images/dish-3.jpeg','Tasty Food','3','Dish',22.99,'Dish');
INSERT INTO tblMenu VALUES('images/dish-4.jpeg','Tasty Food','5','Dish',22.99,'Dish');
INSERT INTO tblMenu VALUES('images/dish-5.jpeg','Tasty Food','2','Dish',2.99,'Dish');
INSERT INTO tblMenu VALUES('images/dish-6.jpeg','Tasty Food','2','Dish',25.99,'Dish');
INSERT INTO tblMenu VALUES('images/dish-8.jpeg','Tasty Food','5','Dish',22.99,'Dish');
INSERT INTO tblMenu VALUES('images/dish-9.jpeg','Fufu Butter Soup','1','Dish',42.99,'Dish');

INSERT INTO tblReview VALUES('Sofia','Kamoo',' I Was Immediately Put Out Of My Misery When I Saw Genie Float Out Of The Kitchen And Present Me With 12,000 Meatloaf Pies.','5');
INSERT INTO tblReview VALUES('Olumide Henrie','Benedict','Food Was Tooooo Salty. Never Cut Marathon (Hard Body) Chicken Into Bits And Never Salt It.','5');
INSERT INTO tblReview VALUES('Themba','Sui','NB: One Of The Few Clubs Around That Closes In Very Late ( 02:00am - 04:00am)Normal Club, With Outdoor Sitting And A Pool Table. Good Music. Tasty African Cuisine. Friendly Service.','5');
INSERT INTO tblReview VALUES('Tshiamo','Monageng','A platter consisting of cassavawas the best dish i had ever eaten. thanks and big ups to the chef.','5');


select * from tblMenu;

select * from tblMenu where Category ='Dish';
select * from tblMenu where Category ='Menu';
--drop table Dishes;
--drop table [tblUsers];



/*
drop table tblMenu
drop table tblUsers
drop table tblDish
drop table tblReview
drop table Cart

*/



