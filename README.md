# Unifty
Bridge Swift and Objective-C for Unity native plugins.

Unifty provides a little Bridging Header and set it up for you on PostProcessBuild :rocket:

## Usage
Write plugins in Swift and you are ready to use Unifty.

**Plugin.mm**

```objective-c
#import <YourProduct-Swift.h>

extern "C" {
    [Messenger echo:"I'm sending message over Unifty!"];
}
```

**Messenger.swift**

```swift
public class Messenger: NSObject {
    public class func echo(text: String) {
        Unifty.SendMessage("MessageReceiver", "OnReceiveMessage", text)
    }
}
```

## Methods
Since I support the idea of YAGNI, only few methods are available now.

- `UnitySendMessage` >> `Unifty.SendMessage`
- `UnityGetGLViewController` >> `Unifty.GetGLViewController`

Add other methods when you want to use it. And pull requests are always welcome :pray:
