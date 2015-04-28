clc
clear all
close all
for x=1:60
    i=x;
    i=int2str(i);
    name=strcat('a (',i,').jpg');
    k=imread(name);
    nam=strcat(i,'.jpg');
    imwrite(k,nam);
    
end
