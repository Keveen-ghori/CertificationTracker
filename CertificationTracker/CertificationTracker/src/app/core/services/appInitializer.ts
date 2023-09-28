import { Observable, catchError, of } from 'rxjs';
import { UserService } from './user.service';

export function appInitializer(authService: UserService) {
  return () =>
    new Promise((resolve: any) => {
      authService.refreshToken().subscribe().add(resolve);
    });
}
