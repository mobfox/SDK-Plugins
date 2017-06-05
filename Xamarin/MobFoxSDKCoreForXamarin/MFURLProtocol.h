//
//  MFURLProtocol.h
//  DemoApp
//
//  Created by Itamar Nabriski on 16/01/2017.
//  Copyright © 2017 Matomy Media Group Ltd. All rights reserved.
//

#ifndef MFURLProtocol_h
#define MFURLProtocol_h
#import <Foundation/Foundation.h>
#import <MobFoxSDKCore/MobFoxSDKCore.h>


@interface MFURLProtocol : NSURLProtocol <NSURLConnectionDelegate>


+ (void)setURLsArray:(NSMutableArray *)value;
+ (NSMutableArray *)urlsArray;

@end

#endif /* MFURLProtocol_h */
