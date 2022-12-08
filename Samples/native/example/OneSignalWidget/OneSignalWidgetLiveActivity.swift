//
//  OneSignalWidgetLiveActivity.swift
//  OneSignalWidget
//
//  Created by Brian Smith on 11/30/22.
//

import ActivityKit
import WidgetKit
import SwiftUI
import OneSignalLiveActivity

@available(iOSApplicationExtension 16.1, *)
struct OneSignalWidgetLiveActivity: Widget {
    var body: some WidgetConfiguration {
        ActivityConfiguration(for: OneSignalWidgetAttributes.self) { context in
            // Lock screen/banner UI goes here\VStack(alignment: .leading) {
            VStack {
                Spacer()
                Text(context.attributes.title).font(.headline)
                Spacer()
                HStack {
                    Spacer()
                    Text(context.state.message)
                    Spacer()
                }
                Spacer()
            }
            .activitySystemActionForegroundColor(.black)
            .activityBackgroundTint(.white)
        } dynamicIsland: { context in
            DynamicIsland {
                // Expanded UI goes here.  Compose the expanded UI through
                // various regions, like leading/trailing/center/bottom
                DynamicIslandExpandedRegion(.leading) {
                    Text("Leading")
                }
                DynamicIslandExpandedRegion(.trailing) {
                    Text("Trailing")
                }
                DynamicIslandExpandedRegion(.bottom) {
                    Text("Bottom")
                    // more content
                }
            } compactLeading: {
                Text("L")
            } compactTrailing: {
                Text("T")
            } minimal: {
                Text("Min")
            }
            .widgetURL(URL(string: "http://www.apple.com"))
            .keylineTint(Color.red)
        }
    }
}
