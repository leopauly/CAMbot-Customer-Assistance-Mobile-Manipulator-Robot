clc
clear all
close all
for i=0:2
w=int2str(i);
im=imread(strcat(w,'.jpg'));
%im=rgb2gray(im);
im=imresize(im,[243 320]);
imwrite(im,strcat(w,'.jpg'))
end