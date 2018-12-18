//
//  NetmeraPushObject.h
//
//
//  Created by Yavuz Nuzumlali on 09/10/15.
//
//

#import <Netmera/NetmeraBaseModel.h>
#import <Netmera/NetmeraPushObjectAlert.h>
#import <Netmera/NetmeraPushObjectAction.h>

typedef NS_ENUM(NSUInteger, NetmeraPushType) {
  NetmeraPushTypeStandard = 1,
  NetmeraPushTypeInteractive = 2,
  NetmeraPushTypePopup = 3,
  NetmeraPushTypeSilent = 6,
  NetmeraPushTypePing = 7,
  NetmeraPushTypeConfigUpdate = 8,
  NetmeraPushTypeInAppMessage = 10
};

typedef NS_OPTIONS(NSUInteger, NetmeraInboxStatus) {
  NetmeraInboxStatusRead = 1 << 0,
  NetmeraInboxStatusUnread = 1 << 1,
  NetmeraInboxStatusDeleted = 1 << 2,
  NetmeraInboxStatusAll = NetmeraInboxStatusRead | NetmeraInboxStatusUnread | NetmeraInboxStatusDeleted,
};

@interface NetmeraPushObject : NetmeraBaseModel

@property (nonatomic, assign, readonly) NetmeraPushType pushType;

@property (nonatomic, copy, readonly) NSString *pushInstanceId;
@property (nonatomic, copy, readonly) NSString *pushId;
@property (nonatomic, copy, readonly) NSString *externalId;

@property (nonatomic, strong, readonly) NetmeraPushObjectAlert *alert;
@property (nonatomic, copy, readonly) NSString *sound;
@property (nonatomic, assign, readonly) NSUInteger badge;
@property (nonatomic, copy, readonly) NSArray *category;
@property (nonatomic, copy, readonly) NSArray *carousel;
@property (nonatomic, copy, readonly) NSString *interactiveCategoryIdentifier;
@property (nonatomic, strong, readonly) NSURL *mediaAttachmentURL;

@property (nonatomic, strong, readonly) NSDictionary *customDictionary;
@property (nonatomic, assign, readonly) NetmeraInboxStatus inboxStatus;
@property (nonatomic, assign, readonly) BOOL includedInInbox;
@property (nonatomic, strong, readonly) NSDate *expirationDate;
@property (nonatomic, strong, readonly) NSDate *sendDate;

@property (nonatomic, strong, readonly) NetmeraPushObjectAction *action;

@end
