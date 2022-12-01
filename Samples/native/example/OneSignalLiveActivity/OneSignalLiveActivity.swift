//
//  OneSignalLiveActivity.swift
//  OneSignalLiveActivity
//
//  Created by Brian Smith on 11/30/22.
//

import Foundation
import ActivityKit
import OSLog

public struct OneSignalWidgetAttributes: ActivityAttributes {
    public struct ContentState: Codable, Hashable {
        // Dynamic stateful properties about your activity go here!
        public var message: String
    }

    // Fixed non-changing properties about your activity go here!
    public var title: String
}

@objc(OneSignalLiveActivity)
public class OneSignalLiveActivity : NSObject {

    @objc
    public func startLiveActivity(recievedToken: @escaping (_: String) -> Void) -> Void {
        let logger = Logger()
        logger.log("Entering startLiveActivity()")
        if #available(iOS 16.1, *) {
            let attributes = OneSignalWidgetAttributes(title: "OneSignal Dev App Live Activity")
            let contentState = OneSignalWidgetAttributes.ContentState(message: "Update this message through push or with Activity Kit")

            do {
                let activity = try Activity<OneSignalWidgetAttributes>.request(
                    attributes: attributes,
                    contentState: contentState,
                    pushType: .token)
                print(activity.id)
                Task {
                    for await token in activity.pushTokenUpdates {
                        let myToken = token.map {String(format: "%02x", $0)}.joined()
                        recievedToken(myToken)
                    }
                }
            } catch (let error) {
                print(error.localizedDescription)
            }
        }
    }
}
