create database task_25_12
use task_25_12

create table actors (
act_id int primary key identity,
act_fname varchar(20),
act_lname varchar(20) ,
act_gender varchar(1)
)

create table movies (
mov_id int primary key identity ,
mov_title varchar(50),
mov_year int ,
mov_time int ,
mov_lang varchar(50),
mov_dat_rel datetime ,
mov_rel_country varchar(50)
)

create table movie_cast (
act_id int,
mov_id int ,
role varchar(30)
primary key(act_id,mov_id)
foreign key (act_id) references actors(act_id),
foreign key (mov_id) references movies(mov_id)
)

create table directors (
dir_id int primary key identity ,
dir_fname varchar(20),
dir_lname varchar (20) 
)

create table movie_direction(
dir_id int ,
mov_id int,
primary key ( dir_id,mov_id),
foreign key (dir_id) references directors(dir_id),
foreign key (mov_id) references movies(mov_id)
)

create table reviewers (
rev_id int primary key identity ,
rev_name varchar(30)
)

create table ratings (
mov_id int,
rev_id int ,
rev_stars int ,
num_o_ratings int ,
primary key (mov_id , rev_id ),
foreign key (mov_id) references movies(mov_id),
foreign key (rev_id) references reviewers(rev_id)
)

create table geners (
gen_id int primary key identity ,
gen_title varchar(20)
)

create table movie_geners (
mov_id int ,
gen_id int,
primary key(mov_id,gen_id),
foreign key (mov_id) references movies(mov_id),
foreign key (gen_id) references geners(gen_id)
)