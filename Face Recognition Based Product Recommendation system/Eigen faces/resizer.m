clc
clear all
close all
for i=99:105
w=int2str(i);
im=imread(strcat(w,'.jpg'));
%im=rgb2gray(im);
im=imresize(im,[112 92]);
imwrite(im,strcat(w,'.jpg'))
end