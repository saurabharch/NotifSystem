namespace NotifSystem.Default {
    export namespace DemoNotificationService {
        export const baseUrl = 'Default/DemoNotification';

        export declare function SendNotification(request: SendNotificationRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            SendNotification = "Default/DemoNotification/SendNotification"
        }

        [
            'SendNotification'
        ].forEach(x => {
            (<any>DemoNotificationService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

