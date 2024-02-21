create database QuanLyTaiKhoan
use QuanLyTaiKhoan
CREATE TABLE Users
(
    UserID NVARCHAR(20) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL ,
    Pass_word NVARCHAR(255) NOT NULL,
    User_Role NVARCHAR(50) default 'normal employees'
)
INSERT INTO Users (UserID, Username, Pass_word, User_Role) VALUES ('User_01', 'nguoimot', '123456', 'normal employees');
INSERT INTO Users (UserID, Username, Pass_word, User_Role) VALUES ('User_02', 'nguoihai', '123456', 'normal employees');
INSERT INTO Users (UserID, Username, Pass_word, User_Role) VALUES ('User_03', 'nguoiba', '123456', 'normal employees');
INSERT INTO Users (UserID, Username, Pass_word, User_Role) VALUES ('User_04', 'nguoitu', '123456', 'normal employees');
INSERT INTO Users (UserID, Username, Pass_word, User_Role) VALUES ('User_05', 'nguoilam', '123456', 'normal employees');


Delete from Users where Users.Pass_word='123456'

Select * from Users