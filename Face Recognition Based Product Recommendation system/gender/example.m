% A sample script, which shows the usage of functions, included in
% FLD-based face recognition system (Fisherface method)
%
% See also: CREATEDATABASE, FISHERFACECORE, RECOGNITION

% Original version by Amir Hossein Omidvarnia, October 2007
%                     Email: aomidvar@ece.ut.ac.ir                  
function example
clear all
clc


% You can customize and fix initial directory paths
TrainDatabasePath = 'E:\Going On projects\CASKbot\_Presentation\customer robot interaction\all\gender\train';
TestDatabasePath = 'E:\Going On projects\CASKbot\_Presentation\customer robot interaction\all\gender\test';

prompt = {'Enter test image name (a number between 1 to 10):'};
dlg_title = 'Input of FLD-Based Face Recognition System';
num_lines= 1;
def = {'1'};

TestImage  = int2str(2);
TestImage = strcat(TestDatabasePath,'\',char(TestImage),'.jpg');
im = imread(TestImage);

T = CreateDatabase(TrainDatabasePath);
[m V_PCA V_Fisher ProjectedImages_Fisher] = FisherfaceCore(T);
OutputName = Recognition(TestImage, m, V_PCA, V_Fisher, ProjectedImages_Fisher);

SelectedImage = strcat(TrainDatabasePath,'\',OutputName);
SelectedImage = imread(SelectedImage);

imshow(im)
title('Test Image');
figure,imshow(SelectedImage);
title('Equivalent Image');

str = strcat('Matched image is :  ',OutputName);
disp(str)
end