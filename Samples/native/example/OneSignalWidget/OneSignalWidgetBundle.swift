//
//  OneSignalWidgetBundle.swift
//  OneSignalWidget
//
//  Created by Brian Smith on 11/30/22.
//

import WidgetKit
import SwiftUI

@main
struct OneSignalWidgetBundle: WidgetBundle {
    var body: some Widget {
        OneSignalWidget()
        
        if #available(iOS 16.1, *) {
            OneSignalWidgetLiveActivity()
        }
    }
}
