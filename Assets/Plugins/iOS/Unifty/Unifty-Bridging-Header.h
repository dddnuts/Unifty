//
//  Unifty-Bridging-Header.h
//  Unity-iPhone
//
//  Created by dddnuts on 5/6/16.
//
//

#import <UIKit/UIKit.h>

UIViewController* UnityGetGLViewController();

void UnitySendMessage(const char* obj, const char* method, const char* msg);