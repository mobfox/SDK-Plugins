//
//  LocationManager.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 5/2/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MFLocationServicesManager.h"

@interface MFLocationServicesManager()

@property(atomic, assign) bool locationExisted;

@end

@implementation MFLocationServicesManager

+ (instancetype)sharedInstance {
    
    static MFLocationServicesManager *sharedInstance = nil;
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        
        sharedInstance = [[MFLocationServicesManager alloc] init];
        // Do any other initialisation stuff here
        
        sharedInstance.locationManager = [[CLLocationManager alloc] init];
        sharedInstance.locationManager.delegate = sharedInstance;
        sharedInstance.locationManager.distanceFilter = kCLDistanceFilterNone;
        sharedInstance.locationManager.desiredAccuracy = kCLLocationAccuracyBest;
        sharedInstance.accuracy = kCLLocationAccuracyBest;
        
        // MARK: restricts battery drain by getting notified only on significant location changes.
        // MARK: Significant-change location updates require an authorization status of kCLAuthorizationStatusAuthorizedAlways.
        [sharedInstance.locationManager startMonitoringSignificantLocationChanges];

        
        
    });
    return sharedInstance;
    
}

- (void)findLocation {
    
    //NSLog(@"findLocation!");
    
    @synchronized (self) {
        
        if (!self.locationExisted) {
            
            //NSLog(@"finding Location...");

            CLAuthorizationStatus authorizationStatus = [CLLocationManager authorizationStatus];
            
            if(authorizationStatus == kCLAuthorizationStatusRestricted || authorizationStatus == kCLAuthorizationStatusDenied) {
                
                //NSLog(@"app isn't permitted to use location services!");
                
            } else if(authorizationStatus == kCLAuthorizationStatusNotDetermined) {
                
                //NSLog(@"Authorization Status Not Determined!");
                if ([[[UIDevice currentDevice] systemVersion] floatValue] >= 8) {

                    [self.locationManager requestWhenInUseAuthorization];
                }
                
            }
            
            [self.locationManager startUpdatingLocation];
            
            self.locationExisted = true;
            
        }
    }

}

- (void)stopFindingLocation {
    
    //NSLog(@"stopFindingLocation");
    
    [self.locationManager stopUpdatingLocation];
    [self.locationManager stopMonitoringSignificantLocationChanges];
    self.latitude = 0;
    self.longitude = 0;
    
}


#pragma mark - CLLocationManagerDelegate

- (void)locationManager:(CLLocationManager *)manager didFailWithError:(NSError *)error
{
    
    [manager stopUpdatingLocation];
    NSLog(@"error%@",error);
    NSLog(@"didFailWithError: %@", error.description);
    
    switch([error code])
    {
        case kCLErrorNetwork: // general, network-related error
        {
            NSLog(@"please check your network connection or that you are not in airplane mode");
       
        }
        break;
        case kCLErrorDenied:{
            
            NSLog(@"user has denied to use current Location");
  
        }
        break;
        default:
        {
            NSLog(@"unknown network error");
      
        }
        break;
    }
    
}

- (void)locationManager:(CLLocationManager *)manager didUpdateLocations:(NSArray<CLLocation *> *)locations {
    
    //NSLog(@"locationManager:didUpdateLocations:");

    if(locations.count > 0) {
        
        //NSLog(@"locationManager:didUpdateLocations: %@", locations);
    
        CLLocationCoordinate2D coordinate = [[locations lastObject] coordinate];
        self.latitude  = coordinate.latitude;
        self.longitude = coordinate.longitude;
    }
    
    
}

- (void)locationManager:(CLLocationManager *)manager didChangeAuthorizationStatus:(CLAuthorizationStatus)status {
    
    
}


@end
