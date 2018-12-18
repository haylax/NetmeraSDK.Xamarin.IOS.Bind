using System;
using Foundation;
using ObjCRuntime;
using UIKit;
namespace NetmeraSDK.Xamarin.IOS.Bind
{
    // @protocol NetmeraSerializableModel <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NetmeraSerializableModel
    {
        // @required -(instancetype)initWithDictionary:(NSDictionary *)dict;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dict);

        // @required -(BOOL)updateWithDictionary:(NSDictionary *)dict;
        [Abstract]
        [Export("updateWithDictionary:")]
        bool UpdateWithDictionary(NSDictionary dict);

        // @required -(NSDictionary *)dictionaryValue;
        [Abstract]
        [Export("dictionaryValue")]
        NSDictionary DictionaryValue { get; }

        // @required -(NSDictionary *)dictionaryValueWithClassInfo;
        [Abstract]
        [Export("dictionaryValueWithClassInfo")]
        NSDictionary DictionaryValueWithClassInfo { get; }

        // @required -(NSDictionary *)dictionaryValueWithPolicy:(BOOL)shouldPutClassInfo;
        [Abstract]
        [Export("dictionaryValueWithPolicy:")]
        NSDictionary DictionaryValueWithPolicy(bool shouldPutClassInfo);
    }

    interface INetmeraSerializableModel { }

    // @interface NetmeraBaseModel : NSObject <NetmeraSerializableModel>
    [BaseType(typeof(NSObject))]
    interface NetmeraBaseModel : INetmeraSerializableModel
    {
        // -(instancetype)initWithDictionary:(NSDictionary *)dictionaryValue __attribute__((objc_designated_initializer));
        [Export("initWithDictionary:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary dictionaryValue);

        // +(NSDictionary *)keyPathPropertySelectorMapping;
        [Static]
        [Export("keyPathPropertySelectorMapping")]
        NSDictionary KeyPathPropertySelectorMapping { get; }

        // +(NSDictionary *)keyPathClassMapping;
        [Static]
        [Export("keyPathClassMapping")]
        NSDictionary KeyPathClassMapping { get; }

        // -(NSAttributedString *)attributedDebugDescription;
        [Export("attributedDebugDescription")]
        NSAttributedString AttributedDebugDescription { get; }
    }

    // @interface NetmeraUser : NetmeraBaseModel
    [BaseType(typeof(NetmeraBaseModel))]
    interface NetmeraUser
    {
        // @property (copy, nonatomic) NSString * userId;
        [Export("userId")]
        string UserId { get; set; }

        // @property (copy, nonatomic) NSString * email;
        [Export("email")]
        string Email { get; set; }

        // @property (copy, nonatomic) NSString * MSISDN;
        [Export("MSISDN")]
        string MSISDN { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * surname;
        [Export("surname")]
        string Surname { get; set; }

        // @property (copy, nonatomic) NSString * language;
        [Export("language")]
        string Language { get; set; }

        // @property (copy, nonatomic) NSDate * dateOfBirth;
        [Export("dateOfBirth", ArgumentSemantic.Copy)]
        NSDate DateOfBirth { get; set; }

        // @property (assign, nonatomic) NetmeraProfileAttributeGender gender;
        [Export("gender", ArgumentSemantic.Assign)]
        NetmeraProfileAttributeGender Gender { get; set; }

        // @property (assign, nonatomic) NetmeraProfileAttributeMaritalStatus maritalStatus;
        [Export("maritalStatus", ArgumentSemantic.Assign)]
        NetmeraProfileAttributeMaritalStatus MaritalStatus { get; set; }

        // @property (assign, nonatomic) NSUInteger numberOfChildren;
        [Export("numberOfChildren")]
        nuint NumberOfChildren { get; set; }

        // @property (copy, nonatomic) NSString * country;
        [Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * state;
        [Export("state")]
        string State { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * district;
        [Export("district")]
        string District { get; set; }

        // @property (copy, nonatomic) NSString * occupation;
        [Export("occupation")]
        string Occupation { get; set; }

        // @property (copy, nonatomic) NSString * industry;
        [Export("industry")]
        string Industry { get; set; }

        // @property (copy, nonatomic) NSString * favouriteTeam;
        [Export("favouriteTeam")]
        string FavouriteTeam { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * externalSegments;
        [Export("externalSegments", ArgumentSemantic.Copy)]
        string[] ExternalSegments { get; set; }
    }

    // @interface NetmeraPushObjectAlert : NetmeraBaseModel
    [BaseType(typeof(NetmeraBaseModel))]
    interface NetmeraPushObjectAlert
    {
        // @property (copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * subtitle;
        [Export("subtitle")]
        string Subtitle { get; set; }

        // @property (copy, nonatomic) NSString * body;
        [Export("body")]
        string Body { get; set; }

        // -(instancetype)initWithValue:(id)value;
        [Export("initWithValue:")]
        IntPtr Constructor(NSObject value);
    }

    // @interface NetmeraPushObjectAction : NetmeraBaseModel
    [BaseType(typeof(NetmeraBaseModel))]
    interface NetmeraPushObjectAction
    {
        // @property (nonatomic, strong) NSURL * deeplinkURL;
        [Export("deeplinkURL", ArgumentSemantic.Strong)]
        NSUrl DeeplinkURL { get; set; }

        // -(instancetype)initWithValue:(id)value;
        [Export("initWithValue:")]
        IntPtr Constructor(NSObject value);
    }

    // @interface NetmeraPushObject : NetmeraBaseModel
    [BaseType(typeof(NetmeraBaseModel))]
    interface NetmeraPushObject
    {
        // @property (readonly, assign, nonatomic) NetmeraPushType pushType;
        [Export("pushType", ArgumentSemantic.Assign)]
        NetmeraPushType PushType { get; }

        // @property (readonly, copy, nonatomic) NSString * pushInstanceId;
        [Export("pushInstanceId")]
        string PushInstanceId { get; }

        // @property (readonly, copy, nonatomic) NSString * pushId;
        [Export("pushId")]
        string PushId { get; }

        // @property (readonly, copy, nonatomic) NSString * externalId;
        [Export("externalId")]
        string ExternalId { get; }

        // @property (readonly, nonatomic, strong) NetmeraPushObjectAlert * alert;
        [Export("alert", ArgumentSemantic.Strong)]
        NetmeraPushObjectAlert Alert { get; }

        // @property (readonly, copy, nonatomic) NSString * sound;
        [Export("sound")]
        string Sound { get; }

        // @property (readonly, assign, nonatomic) NSUInteger badge;
        [Export("badge")]
        nuint Badge { get; }

        // @property (readonly, copy, nonatomic) NSArray * category;
        [Export("category", ArgumentSemantic.Copy)]
        //[Verify (StronglyTypedNSArray)]
        NSObject[] Category { get; }

        // @property (readonly, copy, nonatomic) NSArray * carousel;
        [Export("carousel", ArgumentSemantic.Copy)]
        //[Verify (StronglyTypedNSArray)]
        NSObject[] Carousel { get; }

        // @property (readonly, copy, nonatomic) NSString * interactiveCategoryIdentifier;
        [Export("interactiveCategoryIdentifier")]
        string InteractiveCategoryIdentifier { get; }

        // @property (readonly, nonatomic, strong) NSURL * mediaAttachmentURL;
        [Export("mediaAttachmentURL", ArgumentSemantic.Strong)]
        NSUrl MediaAttachmentURL { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * customDictionary;
        [Export("customDictionary", ArgumentSemantic.Strong)]
        NSDictionary CustomDictionary { get; }

        // @property (readonly, assign, nonatomic) NetmeraInboxStatus inboxStatus;
        [Export("inboxStatus", ArgumentSemantic.Assign)]
        NetmeraInboxStatus InboxStatus { get; }

        // @property (readonly, assign, nonatomic) BOOL includedInInbox;
        [Export("includedInInbox")]
        bool IncludedInInbox { get; }

        // @property (readonly, nonatomic, strong) NSDate * expirationDate;
        [Export("expirationDate", ArgumentSemantic.Strong)]
        NSDate ExpirationDate { get; }

        // @property (readonly, nonatomic, strong) NSDate * sendDate;
        [Export("sendDate", ArgumentSemantic.Strong)]
        NSDate SendDate { get; }

        // @property (readonly, nonatomic, strong) NetmeraPushObjectAction * action;
        [Export("action", ArgumentSemantic.Strong)]
        NetmeraPushObjectAction Action { get; }
    }

    // @protocol NetmeraPushDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NetmeraPushDelegate
    {
        // @optional -(BOOL)shouldHandleWebViewPresentationForPushObject:(NetmeraPushObject *)object;
        [Export("shouldHandleWebViewPresentationForPushObject:")]
        bool ShouldHandleWebViewPresentationForPushObject(NetmeraPushObject @object);

        // @optional -(void)handleWebViewPresentationForPushObject:(NetmeraPushObject *)object;
        [Export("handleWebViewPresentationForPushObject:")]
        void HandleWebViewPresentationForPushObject(NetmeraPushObject @object);

        // @optional -(BOOL)shouldHandlePresentationForPushObject:(NetmeraPushObject *)object;
        [Export("shouldHandlePresentationForPushObject:")]
        bool ShouldHandlePresentationForPushObject(NetmeraPushObject @object);

        // @optional -(void)handlePresentationForPushObject:(NetmeraPushObject *)object;
        [Export("handlePresentationForPushObject:")]
        void HandlePresentationForPushObject(NetmeraPushObject @object);
    }

    // @interface NetmeraInboxFilter : NetmeraBaseModel
    [BaseType(typeof(NetmeraBaseModel))]
    interface NetmeraInboxFilter
    {
        // @property (assign, nonatomic) NetmeraInboxStatus status;
        [Export("status", ArgumentSemantic.Assign)]
        NetmeraInboxStatus Status { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * categories;
        [Export("categories", ArgumentSemantic.Strong)]
        string[] Categories { get; set; }

        // @property (assign, nonatomic) int pageSize;
        [Export("pageSize")]
        int PageSize { get; set; }

        // @property (assign, nonatomic) BOOL shouldIncludeExpiredObjects;
        [Export("shouldIncludeExpiredObjects")]
        bool ShouldIncludeExpiredObjects { get; set; }
    }

    // @interface NetmeraInbox : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface NetmeraInbox
    {
        // @property (readonly, nonatomic, strong) NSMutableArray<NetmeraPushObject *> * _Nonnull objects;
        [Export("objects", ArgumentSemantic.Strong)]
        NetmeraPushObject[] Objects { get; }

        // @property (readonly, assign, nonatomic) BOOL hasNextPage;
        [Export("hasNextPage")]
        bool HasNextPage { get; }

        // @property (readonly, assign, nonatomic) int pageSize;
        [Export("pageSize")]
        int PageSize { get; }

        // -(NSUInteger)countForStatus:(NetmeraInboxStatus)status;
        [Export("countForStatus:")]
        nuint CountForStatus(NetmeraInboxStatus status);

        // -(void)fetchNextPageWithCompletionBlock:(void (^ _Nonnull)(NSError * _Nonnull))completionBlock;
        [Export("fetchNextPageWithCompletionBlock:")]
        void FetchNextPageWithCompletionBlock(Action<NSError> completionBlock);

        // -(void)updateStatus:(NetmeraInboxStatus)status forPushObjects:(NSArray<NetmeraPushObject *> * _Nonnull)objects completion:(void (^ _Nonnull)(NSError * _Nonnull))completionBlock;
        [Export("updateStatus:forPushObjects:completion:")]
        void UpdateStatus(NetmeraInboxStatus status, NetmeraPushObject[] objects, Action<NSError> completionBlock);
    }

    // @interface NetmeraEvent : NetmeraBaseModel
    [BaseType(typeof(NetmeraBaseModel))]
    [DisableDefaultCtor]
    interface NetmeraEvent
    {
        // @property (readonly, copy, nonatomic) NSString * eventKey;
        [Export("eventKey")]
        string EventKey { get; }

        // @property (assign, nonatomic) double revenue;
        [Export("revenue")]
        double Revenue { get; set; }

        // +(instancetype)event;
        [Static]
        [Export("event")]
        NetmeraEvent Event();
    }

    // @interface NetmeraBannerClickEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraBannerClickEvent
    {
        // @property (readonly, copy, nonatomic) NSString * bannerId;
        [Export("bannerId")]
        string BannerId { get; }

        // @property (nonatomic, strong) NSArray<NSString *> * keywords;
        [Export("keywords", ArgumentSemantic.Strong)]
        string[] Keywords { get; set; }

        // +(instancetype)eventWithBannerId:(NSString *)bannerId;
        [Static]
        [Export("eventWithBannerId:")]
        NetmeraBannerClickEvent EventWithBannerId(string bannerId);
    }

    // @interface NetmeraInAppPurchaseEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    [DisableDefaultCtor]
    interface NetmeraInAppPurchaseEvent
    {
        // @property (readonly, copy, nonatomic) NSString * productId;
        [Export("productId")]
        string ProductId { get; }

        // @property (readonly, copy, nonatomic) NSString * productName;
        [Export("productName")]
        string ProductName { get; }

        // @property (readonly, assign, nonatomic) double price;
        [Export("price")]
        double Price { get; }

        // @property (nonatomic, strong) NSArray<NSString *> * categoryIds;
        [Export("categoryIds", ArgumentSemantic.Strong)]
        string[] CategoryIds { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * categoryNames;
        [Export("categoryNames", ArgumentSemantic.Strong)]
        string[] CategoryNames { get; set; }

        // @property (assign, nonatomic) NSUInteger count;
        [Export("count")]
        nuint Count { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * keywords;
        [Export("keywords", ArgumentSemantic.Strong)]
        string[] Keywords { get; set; }

        // +(instancetype)eventWithId:(NSString *)productId name:(NSString *)productName price:(double)price;
        [Static]
        [Export("eventWithId:name:price:")]
        NetmeraInAppPurchaseEvent EventWithId(string productId, string productName, double price);
    }

    // @interface NetmeraLoginEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraLoginEvent
    {
        // @property (readonly, copy, nonatomic) NSString * userId;
        [Export("userId")]
        string UserId { get; }

        // +(instancetype)eventWithUserId:(NSString *)userId;
        [Static]
        [Export("eventWithUserId:")]
        NetmeraLoginEvent EventWithUserId(string userId);
    }

    // @interface NetmeraRegisterEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraRegisterEvent
    {
        // @property (readonly, copy, nonatomic) NSString * userId;
        [Export("userId")]
        string UserId { get; }

        // +(instancetype)eventWithUserId:(NSString *)userId;
        [Static]
        [Export("eventWithUserId:")]
        NetmeraRegisterEvent EventWithUserId(string userId);
    }

    // @interface NetmeraSearchEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraSearchEvent
    {
        // @property (readonly, copy, nonatomic) NSString * query;
        [Export("query")]
        string Query { get; }

        // @property (readonly, assign, nonatomic) NSUInteger resultCount;
        [Export("resultCount")]
        nuint ResultCount { get; }

        // +(instancetype)eventWithQuery:(NSString *)query resultCount:(NSUInteger)resultCount;
        [Static]
        [Export("eventWithQuery:resultCount:")]
        NetmeraSearchEvent EventWithQuery(string query, nuint resultCount);
    }

    // @interface NetmeraShareEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraShareEvent
    {
        // @property (readonly, copy, nonatomic) NSString * channel;
        [Export("channel")]
        string Channel { get; }

        // @property (readonly, copy, nonatomic) NSString * content;
        [Export("content")]
        string Content { get; }

        // +(instancetype)eventWithChannel:(NSString *)channel content:(NSString *)content;
        [Static]
        [Export("eventWithChannel:content:")]
        NetmeraShareEvent EventWithChannel(string channel, string content);
    }

    // @interface NetmeraCategoryViewEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraCategoryViewEvent
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull categoryId;
        [Export("categoryId")]
        string CategoryId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull categoryName;
        [Export("categoryName")]
        string CategoryName { get; }

        // +(instancetype _Nonnull)eventWithCategoryId:(NSString * _Nonnull)categoryId categoryName:(NSString * _Nonnull)categoryName;
        [Static]
        [Export("eventWithCategoryId:categoryName:")]
        NetmeraCategoryViewEvent EventWithCategoryId(string categoryId, string categoryName);
    }

    // @interface NetmeraProduct : NetmeraBaseModel
    [BaseType(typeof(NetmeraBaseModel))]
    [DisableDefaultCtor]
    interface NetmeraProduct
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull productId;
        [Export("productId")]
        string ProductId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull productName;
        [Export("productName")]
        string ProductName { get; }

        // @property (readonly, assign, nonatomic) double price;
        [Export("price")]
        double Price { get; }

        // @property (nonatomic, strong) NSArray<NSString *> * _Nonnull categoryIds;
        [Export("categoryIds", ArgumentSemantic.Strong)]
        string[] CategoryIds { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * _Nonnull categoryNames;
        [Export("categoryNames", ArgumentSemantic.Strong)]
        string[] CategoryNames { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull brandId;
        [Export("brandId")]
        string BrandId { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull brandName;
        [Export("brandName")]
        string BrandName { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull variant;
        [Export("variant")]
        string Variant { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * _Nonnull keywords;
        [Export("keywords", ArgumentSemantic.Strong)]
        string[] Keywords { get; set; }

        // +(instancetype _Nonnull)productWithId:(NSString * _Nonnull)productId name:(NSString * _Nonnull)productName price:(double)price;
        [Static]
        [Export("productWithId:name:price:")]
        NetmeraProduct ProductWithId(string productId, string productName, double price);
    }

    // @interface NetmeraLineItem : NetmeraProduct
    [BaseType(typeof(NetmeraProduct))]
    interface NetmeraLineItem
    {
        // @property (readonly, assign, nonatomic) NSUInteger count;
        [Export("count")]
        nuint Count { get; }

        // @property (copy, nonatomic) NSString * campaignId;
        [Export("campaignId")]
        string CampaignId { get; set; }

        // +(instancetype)itemWithId:(NSString *)productId name:(NSString *)productName price:(double)price count:(NSUInteger)count;
        [Static]
        [Export("itemWithId:name:price:count:")]
        NetmeraLineItem ItemWithId(string productId, string productName, double price, nuint count);
    }

    // @interface NetmeraBaseProductEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraBaseProductEvent
    {
        // @property (readonly, nonatomic, strong) NetmeraProduct * product;
        [Export("product", ArgumentSemantic.Strong)]
        NetmeraProduct Product { get; }

        // +(instancetype)eventWithProduct:(NetmeraProduct *)product;
        [Static]
        [Export("eventWithProduct:")]
        NetmeraBaseProductEvent EventWithProduct(NetmeraProduct product);
    }

    // @interface NetmeraProductRateEvent : NetmeraBaseProductEvent
    [BaseType(typeof(NetmeraBaseProductEvent))]
    interface NetmeraProductRateEvent
    {
        // @property (readonly, assign, nonatomic) NSUInteger rating;
        [Export("rating")]
        nuint Rating { get; }

        // +(instancetype)eventWithProduct:(NetmeraProduct *)product rating:(NSUInteger)rating;
        [Static]
        [Export("eventWithProduct:rating:")]
        NetmeraProductRateEvent EventWithProduct(NetmeraProduct product, nuint rating);
    }

    // @interface NetmeraCartViewEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraCartViewEvent
    {
        // @property (readonly, assign, nonatomic) double subTotal;
        [Export("subTotal")]
        double SubTotal { get; }

        // @property (readonly, assign, nonatomic) NSUInteger itemCount;
        [Export("itemCount")]
        nuint ItemCount { get; }

        // +(instancetype)eventWithSubTotal:(double)subTotal itemCount:(NSUInteger)itemCount;
        [Static]
        [Export("eventWithSubTotal:itemCount:")]
        NetmeraCartViewEvent EventWithSubTotal(double subTotal, nuint itemCount);
    }

    // @interface NetmeraCartAddProductEvent : NetmeraBaseProductEvent
    [BaseType(typeof(NetmeraBaseProductEvent))]
    interface NetmeraCartAddProductEvent
    {
        // @property (readonly, assign, nonatomic) NSUInteger count;
        [Export("count")]
        nuint Count { get; }

        // +(instancetype)eventWithProduct:(NetmeraProduct *)product count:(NSUInteger)productCount;
        [Static]
        [Export("eventWithProduct:count:")]
        NetmeraCartAddProductEvent EventWithProduct(NetmeraProduct product, nuint productCount);
    }

    // @interface NetmeraCartRemoveProductEvent : NetmeraBaseProductEvent
    [BaseType(typeof(NetmeraBaseProductEvent))]
    interface NetmeraCartRemoveProductEvent
    {
        // @property (readonly, assign, nonatomic) NSUInteger count;
        [Export("count")]
        nuint Count { get; }

        // +(instancetype)eventWithProduct:(NetmeraProduct *)product count:(NSUInteger)productCount;
        [Static]
        [Export("eventWithProduct:count:")]
        NetmeraCartRemoveProductEvent EventWithProduct(NetmeraProduct product, nuint productCount);
    }

    // @interface NetmeraOrderCancelEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraOrderCancelEvent
    {
        // @property (readonly, assign, nonatomic) double subTotal;
        [Export("subTotal")]
        double SubTotal { get; }

        // @property (readonly, assign, nonatomic) double grandTotal;
        [Export("grandTotal")]
        double GrandTotal { get; }

        // @property (readonly, assign, nonatomic) NSUInteger itemCount;
        [Export("itemCount")]
        nuint ItemCount { get; }

        // @property (copy, nonatomic) NSString * paymentMethod;
        [Export("paymentMethod")]
        string PaymentMethod { get; set; }

        // +(instancetype)eventWithSubTotal:(double)subTotal grandTotal:(double)grandTotal itemCount:(NSUInteger)itemCount;
        [Static]
        [Export("eventWithSubTotal:grandTotal:itemCount:")]
        NetmeraOrderCancelEvent EventWithSubTotal(double subTotal, double grandTotal, nuint itemCount);
    }

    // @interface NetmeraProductCommentEvent : NetmeraBaseProductEvent
    [BaseType(typeof(NetmeraBaseProductEvent))]
    interface NetmeraProductCommentEvent
    {
    }

    // @interface NetmeraProductViewEvent : NetmeraBaseProductEvent
    [BaseType(typeof(NetmeraBaseProductEvent))]
    interface NetmeraProductViewEvent
    {
    }

    // @interface NetmeraPurchaseEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraPurchaseEvent
    {
        // @property (readonly, assign, nonatomic) double subTotal;
        [Export("subTotal")]
        double SubTotal { get; }

        // @property (readonly, assign, nonatomic) double grandTotal;
        [Export("grandTotal")]
        double GrandTotal { get; }

        // @property (readonly, nonatomic, strong) NSArray<NetmeraLineItem *> * lineItems;
        [Export("lineItems", ArgumentSemantic.Strong)]
        NetmeraLineItem[] LineItems { get; }

        // @property (copy, nonatomic) NSString * paymentMethod;
        [Export("paymentMethod")]
        string PaymentMethod { get; set; }

        // @property (assign, nonatomic) double shippingCost;
        [Export("shippingCost")]
        double ShippingCost { get; set; }

        // @property (assign, nonatomic) double discount;
        [Export("discount")]
        double Discount { get; set; }

        // @property (copy, nonatomic) NSString * coupon;
        [Export("coupon")]
        string Coupon { get; set; }

        // +(instancetype)eventWithSubTotal:(double)subTotal grandTotal:(double)grandTotal lineItems:(NSArray<NetmeraLineItem *> *)lineItems;
        [Static]
        [Export("eventWithSubTotal:grandTotal:lineItems:")]
        NetmeraPurchaseEvent EventWithSubTotal(double subTotal, double grandTotal, NetmeraLineItem[] lineItems);
    }

    // @interface NetmeraContent : NetmeraBaseModel
    [BaseType(typeof(NetmeraBaseModel))]
    interface NetmeraContent
    {
        // @property (readonly, copy, nonatomic) NSString * contentId;
        [Export("contentId")]
        string ContentId { get; }

        // @property (readonly, copy, nonatomic) NSString * contentName;
        [Export("contentName")]
        string ContentName { get; }

        // @property (readonly, assign, nonatomic) NetmeraEventContentType contentType;
        [Export("contentType", ArgumentSemantic.Assign)]
        NetmeraEventContentType ContentType { get; }

        // @property (nonatomic, strong) NSArray<NSString *> * categoryIds;
        [Export("categoryIds", ArgumentSemantic.Strong)]
        string[] CategoryIds { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * categoryNames;
        [Export("categoryNames", ArgumentSemantic.Strong)]
        string[] CategoryNames { get; set; }

        // @property (copy, nonatomic) NSString * provider;
        [Export("provider")]
        string Provider { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * keywords;
        [Export("keywords", ArgumentSemantic.Strong)]
        string[] Keywords { get; set; }

        // +(instancetype)contentWithId:(NSString *)contentId name:(NSString *)contentName type:(NetmeraEventContentType)contentType;
        [Static]
        [Export("contentWithId:name:type:")]
        NetmeraContent ContentWithId(string contentId, string contentName, NetmeraEventContentType contentType);
    }

    // @interface NetmeraBaseContentEvent : NetmeraEvent
    [BaseType(typeof(NetmeraEvent))]
    interface NetmeraBaseContentEvent
    {
        // @property (readonly, nonatomic, strong) NetmeraContent * content;
        [Export("content", ArgumentSemantic.Strong)]
        NetmeraContent Content { get; }

        // +(instancetype)eventWithContent:(NetmeraContent *)content;
        [Static]
        [Export("eventWithContent:")]
        NetmeraBaseContentEvent EventWithContent(NetmeraContent content);
    }

    // @interface NetmeraContentCommentEvent : NetmeraBaseContentEvent
    [BaseType(typeof(NetmeraBaseContentEvent))]
    interface NetmeraContentCommentEvent
    {
    }

    // @interface NetmeraContentRateEvent : NetmeraBaseContentEvent
    [BaseType(typeof(NetmeraBaseContentEvent))]
    interface NetmeraContentRateEvent
    {
        // @property (readonly, assign, nonatomic) NSUInteger rating;
        [Export("rating")]
        nuint Rating { get; }

        // +(instancetype)eventWithContent:(NetmeraContent *)content rating:(NSUInteger)rating;
        [Static]
        [Export("eventWithContent:rating:")]
        NetmeraContentRateEvent EventWithContent(NetmeraContent content, nuint rating);
    }

    // @interface NetmeraContentViewEvent : NetmeraBaseContentEvent
    [BaseType(typeof(NetmeraBaseContentEvent))]
    interface NetmeraContentViewEvent
    {
    }

    // @interface Netmera : NSObject
    [BaseType(typeof(NSObject))]
    interface Netmera
    {
        // +(void)start;
        [Static]
        [Export("start")]
        void Start();

        // +(void)setAPIKey:(NSString * _Nullable)APIKey;
        [Static]
        [Export("setAPIKey:")]
        void SetAPIKey([NullAllowed] string APIKey);

        // +(void)setBaseURL:(NSString * _Nonnull)URLString;
        [Static]
        [Export("setBaseURL:")]
        void SetBaseURL(string URLString);

        // +(void)setLogLevel:(NetmeraLogLevel)level;
        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel(NetmeraLogLevel level);

        // +(void)setPushDelegate:(NSObject<NetmeraPushDelegate> * _Nonnull)delegate;
        [Static]
        [Export("setPushDelegate:")]
        void SetPushDelegate(NetmeraPushDelegate @delegate);

        // +(void)loadWebViewContentInWebView:(UIWebView * _Nonnull)webView;
        [Static]
        [Export("loadWebViewContentInWebView:")]
        void LoadWebViewContentInWebView(UIWebView webView);

        // +(NetmeraPushObject * _Nullable)recentPushObject;
        [Static]
        [NullAllowed, Export("recentPushObject")]
        NetmeraPushObject RecentPushObject { get; }

        // +(void)handlePushObject:(NetmeraPushObject * _Nonnull)pushObject;
        [Static]
        [Export("handlePushObject:")]
        void HandlePushObject(NetmeraPushObject pushObject);

        // +(void)requestPushNotificationAuthorizationForTypes:(UIUserNotificationType)types;
        [Static]
        [Export("requestPushNotificationAuthorizationForTypes:")]
        void RequestPushNotificationAuthorizationForTypes(UIUserNotificationType types);

        // +(void)setEnabledReceivingPushNotifications:(BOOL)enabled;
        [Static]
        [Export("setEnabledReceivingPushNotifications:")]
        void SetEnabledReceivingPushNotifications(bool enabled);

        // +(BOOL)isEnabledReceivingPushNotifications;
        [Static]
        [Export("isEnabledReceivingPushNotifications")]
        bool IsEnabledReceivingPushNotifications { get; }

        // +(void)setEnabledPopupPresentation:(BOOL)enabled;
        [Static]
        [Export("setEnabledPopupPresentation:")]
        void SetEnabledPopupPresentation(bool enabled);

        // +(void)setEnabledInAppMessagePresentation:(BOOL)enabled;
        [Static]
        [Export("setEnabledInAppMessagePresentation:")]
        void SetEnabledInAppMessagePresentation(bool enabled);

        // +(void)enablePopupPresentation __attribute__((deprecated("Use -setEnabledPopupPresentation: instead", "setEnabledPopupPresentation:YES")));
        [Static]
        [Export("enablePopupPresentation")]
        void EnablePopupPresentation();

        // +(void)disablePopupPresentation __attribute__((deprecated("Use -setEnabledPopupPresentation: instead", "setEnabledPopupPresentation:NO")));
        [Static]
        [Export("disablePopupPresentation")]
        void DisablePopupPresentation();

        // +(void)requestLocationAuthorization;
        [Static]
        [Export("requestLocationAuthorization")]
        void RequestLocationAuthorization();

        // +(void)fetchInboxUsingFilter:(NetmeraInboxFilter * _Nonnull)filter completion:(void (^ _Nonnull)(NetmeraInbox * _Nonnull, NSError * _Nonnull))completionBlock;
        [Static]
        [Export("fetchInboxUsingFilter:completion:")]
        void FetchInboxUsingFilter(NetmeraInboxFilter filter, Action<NetmeraInbox, NSError> completionBlock);

        // +(void)updateUser:(__kindof NetmeraUser * _Nonnull)user;
        [Static]
        [Export("updateUser:")]
        void UpdateUser(NetmeraUser user);

        // +(void)sendEvent:(__kindof NetmeraEvent * _Nonnull)event;
        [Static]
        [Export("sendEvent:")]
        void SendEvent(NetmeraEvent @event);
    }
}
