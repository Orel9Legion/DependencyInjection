using DependencyInjection.Interfaces;
using DependencyInjection.Services;
IMessageService messageService = new EmailService();
NotificationService notificationService = new NotificationService(messageService);
notificationService.Notify();