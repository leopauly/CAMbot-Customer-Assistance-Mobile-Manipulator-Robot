function rec
clc
clear
close all
d=xlsread('database.xlsx');
n=xlsread('newcust.xlsx');
n=[0 0 0 0 1 0];
id=knnsearch(d,n);
d(id,:)
reco=zeros([1 6]);
items=['pens__'; 'pencil'; 'soaps_'; 'bags__'; 'rice__';'plates'];
for i=1:6
   if(d(id,i)==1)
       msgbox(items(i,:));
   end
  imshow('cap.jpg') ;    
end
end