//
//  MobFoxNativeData.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 1/19/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MobFoxNativeData.h"
//#import "NSString+Converter.h"
#import "MFStringExtention.h"

@implementation MobFoxNativeTracker

- (instancetype)initWithURL:(NSURL *)url type:(NSString *)type {
    
    if (self = [super init]) {
        
        self.url = url;
        self.type = type;
        
    }
    
    return  self;

}

@end

@implementation MobFoxNativeImage

- (instancetype)initWithURL:(NSURL *)url width:(NSNumber *)width height:(NSNumber *)height {
    
    if (self = [super init]) {
        
        self.url = url;
        self.width = width;
        self.height = height;
        
    }
    
    return self;
    
}

@end

@implementation MobFoxNativeData



- (instancetype)initWithDictionary:(NSDictionary *)dictionary {
    
    
    if (self = [super init]) {
        
        if (dictionary == nil) {
            return self;
        }
        
       NSDictionary *nativeDict = dictionary[@"native"];
        if (nativeDict) {
            
            NSDictionary *linkDict = nativeDict[@"link"];
            if (linkDict) {
                self.clickURL = [MFStringExtention urlValue:linkDict[@"url"]];
            }
            
            NSArray *assetArray = [[NSArray alloc] init];
            assetArray = nativeDict[@"assets"];
            
            if (assetArray.count >0) {
                
                NSDictionary *iconDict = [assetArray objectAtIndex:0];
                
                if (iconDict) {
                    
                    NSDictionary *img = iconDict[@"img"];
                    NSURL *iconURL = [MFStringExtention urlValue:img[@"url"]];
                    NSNumber *iconWidth = [MFStringExtention numberValue:img[@"w"]];
                    NSNumber *iconHeight =  [MFStringExtention numberValue:img[@"h"]];
                    
                    self.icon = [[MobFoxNativeImage alloc] initWithURL:iconURL width:iconWidth height:iconHeight];
                    
                }
            }
            
            if (assetArray.count >1) {
                
                NSDictionary *mainDict = [assetArray objectAtIndex:1];
                
                if (mainDict) {
                    
                    NSDictionary *img = mainDict[@"img"];
                    NSURL *mainURL = [MFStringExtention urlValue:img[@"url"]];
                    NSNumber *mainWidth = [MFStringExtention numberValue:img[@"w"]];
                    NSNumber *mainHeight =  [MFStringExtention numberValue:img[@"h"]];
                    
                    self.main = [[MobFoxNativeImage alloc] initWithURL:mainURL width:mainWidth height:mainHeight];
                    
                }
            }
            
            if (assetArray.count >2) {
                
                NSDictionary *mainDict = [assetArray objectAtIndex:2];
                
                if (mainDict) {
                    
                    NSDictionary *title = mainDict[@"title"];
                    self.assetHeadline = title[@"text"];
                    
                }
            }
            
            if (assetArray.count >3) {
                
                NSDictionary *mainDict = [assetArray objectAtIndex:3];
                
                if (mainDict) {
                    
                    NSDictionary *title = mainDict[@"data"];
                    self.assetDescription = title[@"value"];
                    
                }
            }
            if (assetArray.count >4) {
                
                NSDictionary *mainDict = [assetArray objectAtIndex:4];
                
                if (mainDict) {
                    
                    NSDictionary *title = mainDict[@"data"];
                    self.callToActionText = title[@"value"];
                    
                }
            }
            if (assetArray.count >5) {
                
                NSDictionary *mainDict = [assetArray objectAtIndex:5];
                
                if (mainDict) {
                    
                    NSDictionary *title = mainDict[@"data"];
                    self.sponsored = title[@"value"];
                    
                }
            }

            
        if (nativeDict[@"imptrackers"]) {
            
            self.trackersArray = [[NSMutableArray alloc] init];
            
            for (NSString *trackerUrl in nativeDict[@"imptrackers"]) {
                
                MobFoxNativeTracker *mobFoxNativeTracker =[[MobFoxNativeTracker alloc] init];
                mobFoxNativeTracker.url = [NSURL URLWithString:trackerUrl];
                
                [self.trackersArray addObject:mobFoxNativeTracker];
            }
        }
        }
    }

    
    
    return self;
    
}

@end
