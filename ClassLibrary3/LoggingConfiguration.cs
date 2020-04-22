using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using JetBrains.Annotations;
using NLog.Layouts;
using NLog.Targets;
using OpenQA.Selenium;

namespace NLog.Config
{
    public class LoggingConfiguration
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern LoggingConfiguration();
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the NLog.Config.LoggingConfiguration class.
#pragma warning disable CS0824 // Constructor is marked external
        public extern LoggingConfiguration(LogFactory logFactory);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the collection of logging rules.
        public IList<LoggingRule> LoggingRules { get; }
        //
        // Summary:
        //     Gets the collection of file names which should be watched for changes by NLog.
        public virtual IEnumerable<string> FileNamesToWatch { get; }
        //
        // Summary:
        //     Gets a collection of named targets specified in the configuration.
        //
        // Returns:
        //     A list of named targets.
        //
        // Remarks:
        //     Unnamed targets (such as those wrapped by other targets) are not returned.
        public ReadOnlyCollection<Target> ConfiguredNamedTargets { get; }
        //
        // Summary:
        //     Gets the variables defined in the configuration.
        public IDictionary<string, SimpleLayout> Variables { get; }
        //
        // Summary:
        //     Use the old exception log handling of NLog 3.0?
        //
        // Remarks:
        //     This method was marked as obsolete on NLog 4.1 and it may be removed in a future
        //     release.
        [Obsolete("This option will be removed in NLog 5. Marked obsolete on NLog 4.1")]
        public bool ExceptionLoggingOldStyle { get; set; }
        //
        // Summary:
        //     Gets the factory that will be configured
        public LogFactory LogFactory { get; }
        //
        // Summary:
        //     Gets or sets the default culture info to use as NLog.LogEventInfo.FormatProvider.
        [CanBeNullAttribute]
        public CultureInfo DefaultCultureInfo { get; set; }
        //
        // Summary:
        //     Gets all targets.
        public ReadOnlyCollection<Target> AllTargets { get; }


        //
        // Summary:
        //     Add a rule with min- and maxLevel.
        //
        // Parameters:
        //   minLevel:
        //     Minimum log level needed to trigger this rule.
        //
        //   maxLevel:
        //     Maximum log level needed to trigger this rule.
        //
        //   targetName:
        //     Name of the target to be written when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRule(LogLevel minLevel, LogLevel maxLevel, string targetName, string loggerNamePattern = "*");
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Add a rule with min- and maxLevel.
        //
        // Parameters:
        //   minLevel:
        //     Minimum log level needed to trigger this rule.
        //
        //   maxLevel:
        //     Maximum log level needed to trigger this rule.
        //
        //   target:
        //     Target to be written to when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
        //
        //   final:
        //     Gets or sets a value indicating whether to quit processing any further rule when
        //     this one matches.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRule(LogLevel minLevel, LogLevel maxLevel, Target target, string loggerNamePattern, bool final);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Add a rule with min- and maxLevel.
        //
        // Parameters:
        //   minLevel:
        //     Minimum log level needed to trigger this rule.
        //
        //   maxLevel:
        //     Maximum log level needed to trigger this rule.
        //
        //   target:
        //     Target to be written to when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRule(LogLevel minLevel, LogLevel maxLevel, Target target, string loggerNamePattern = "*");
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Add a rule for alle loglevels.
        //
        // Parameters:
        //   target:
        //     Target to be written to when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRuleForAllLevels(Target target, string loggerNamePattern = "*");
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Add a rule for alle loglevels.
        //
        // Parameters:
        //   targetName:
        //     Name of the target to be written when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRuleForAllLevels(string targetName, string loggerNamePattern = "*");
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Add a rule for alle loglevels.
        //
        // Parameters:
        //   target:
        //     Target to be written to when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
        //
        //   final:
        //     Gets or sets a value indicating whether to quit processing any further rule when
        //     this one matches.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRuleForAllLevels(Target target, string loggerNamePattern, bool final);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Add a rule for one loglevel.
        //
        // Parameters:
        //   level:
        //     log level needed to trigger this rule.
        //
        //   targetName:
        //     Name of the target to be written when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRuleForOneLevel(LogLevel level, string targetName, string loggerNamePattern = "*");
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Add a rule for one loglevel.
        //
        // Parameters:
        //   level:
        //     log level needed to trigger this rule.
        //
        //   target:
        //     Target to be written to when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRuleForOneLevel(LogLevel level, Target target, string loggerNamePattern = "*");
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Add a rule for one loglevel.
        //
        // Parameters:
        //   level:
        //     log level needed to trigger this rule.
        //
        //   target:
        //     Target to be written to when the rule matches.
        //
        //   loggerNamePattern:
        //     Logger name pattern. It may include the '*' wildcard at the beginning, at the
        //     end or at both ends.
        //
        //   final:
        //     Gets or sets a value indicating whether to quit processing any further rule when
        //     this one matches.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRuleForOneLevel(LogLevel level, Target target, string loggerNamePattern, bool final);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Registers the specified target object under a given name.
        //
        // Parameters:
        //   name:
        //     Name of the target.
        //
        //   target:
        //     The target object.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     when name is null
        //
        //   T:System.ArgumentNullException:
        //     when target is null
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddTarget(string name, Target target);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Registers the specified target object. The name of the target is read from NLog.Targets.Target.Name.
        //
        // Parameters:
        //   target:
        //     The target object with a non null NLog.Targets.Target.Name
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     when target is null
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddTarget([NotNullAttribute] Target target);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Finds the target with the specified name and specified type.
        //
        // Parameters:
        //   name:
        //     The name of the target to be found.
        //
        // Type parameters:
        //   TTarget:
        //     Type of the target
        //
        // Returns:
        //     Found target or null when the target is not found of not of type TTarget
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern TTarget FindTargetByName<TTarget>(string name) where TTarget : Target;
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Finds the target with the specified name.
        //
        // Parameters:
        //   name:
        //     The name of the target to be found.
        //
        // Returns:
        //     Found target or null when the target is not found.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Target FindTargetByName(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Installs target-specific objects on current system.
        //
        // Parameters:
        //   installationContext:
        //     The installation context.
        //
        // Remarks:
        //     Installation typically runs with administrative permissions.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Install(InstallationContext installationContext);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Called by LogManager when one of the log configuration files changes.
        //
        // Returns:
        //     A new instance of NLog.Config.LoggingConfiguration that represents the updated
        //     configuration.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual LoggingConfiguration Reload();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes the specified named target.
        //
        // Parameters:
        //   name:
        //     Name of the target.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void RemoveTarget(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Uninstalls target-specific objects from current system.
        //
        // Parameters:
        //   installationContext:
        //     The installation context.
        //
        // Remarks:
        //     Uninstallation typically runs with administrative permissions.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Uninstall(InstallationContext installationContext);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}