//
//  Unifty.swift
//  Unity-iPhone
//
//  Created by dddnuts on 5/6/16.
//
//

import UIKit

public class Unifty: NSObject {
    /**
     Bridges UnitySendMessage.
     */
    public class func SendMessage(obj: String, method: String, msg: String) {
        UnitySendMessage(obj, method, msg)
    }
    
    /**
     Bridges UnityGetGLViewController
     */
    public class func GetGLViewController() -> UIViewController {
        return UnityGetGLViewController()
    }
}
