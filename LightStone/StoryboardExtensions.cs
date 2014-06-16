using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;

namespace LightStone.Controls
{
    public static class StoryboardExtensions
    {

        public static void AddAnimation(this Storyboard storyboard, DependencyObject element, Timeline timeline, String propertyPath)
        {
            storyboard.Children.Add(timeline);
            Storyboard.SetTarget(timeline, element);
            Storyboard.SetTargetProperty(timeline, propertyPath);
        }

        public static void AddAnimation(this Storyboard storyboard, DependencyObject element,
                                        int duration, double toValue, String propertyPath,
                                        EasingFunctionBase easingFunction = null)
        {
            DoubleAnimation timeline = new DoubleAnimation();
            timeline.To = toValue;
            timeline.Duration = TimeSpan.FromMilliseconds(duration);
            if (easingFunction != null)
                timeline.EasingFunction = easingFunction;

            storyboard.Children.Add(timeline);

            Storyboard.SetTarget(timeline, element);
            Storyboard.SetTargetProperty(timeline, propertyPath);
        }

        public static void AddAnimation(this Storyboard storyboard, DependencyObject element,
                                         int duration,double fromValue, double toValue, String propertyPath,
                                         EasingFunctionBase easingFunction = null)
        {
            DoubleAnimation timeline = new DoubleAnimation();
            timeline.From = fromValue;
            timeline.To = toValue;
            timeline.Duration = TimeSpan.FromMilliseconds(duration);
            if (easingFunction != null)
                timeline.EasingFunction = easingFunction;

            storyboard.Children.Add(timeline);

            Storyboard.SetTarget(timeline, element);
            Storyboard.SetTargetProperty(timeline, propertyPath);
        }



         public static void Animate(this DependencyObject element, string propertyPath, 
                                int duration, double toValue,EasingFunctionBase easingFunction = null, EventHandler<Object> completed = null)
        {
            DoubleAnimation timeline = new DoubleAnimation();
            timeline.To = toValue;
            timeline.Duration = TimeSpan.FromMilliseconds(duration);
            if (easingFunction != null)
                timeline.EasingFunction = easingFunction;

            Storyboard sb = new Storyboard();
            if (completed != null)
                sb.Completed += completed;

            sb.Children.Add(timeline);
            Storyboard.SetTarget(sb, element);
            Storyboard.SetTargetProperty(sb, propertyPath);
            sb.Begin();

        }


         public static void Animate(this DependencyObject element, string propertyPath,
                               int duration, int startingDuration,  double toValue, EasingFunctionBase easingFunction = null, EventHandler<Object> completed = null)
         {
             DoubleAnimation timeline = new DoubleAnimation();
             timeline.To = toValue;
             timeline.Duration = TimeSpan.FromMilliseconds(duration);
             if (easingFunction != null)
                 timeline.EasingFunction = easingFunction;

             Storyboard sb = new Storyboard();
             if (completed != null)
                 sb.Completed += completed;

             sb.Children.Add(timeline);
             Storyboard.SetTarget(sb, element);
             Storyboard.SetTargetProperty(sb, propertyPath);
             sb.BeginTime = TimeSpan.FromMilliseconds(startingDuration);
             sb.Begin();

         }
    }
}
