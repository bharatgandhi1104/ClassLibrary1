﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using BoDi;
using TechTalk.SpecFlow.Plugins;

namespace TechTalk.SpecFlow.Configuration
{
    public class SpecFlowConfiguration
    {
        public extern SpecFlowConfiguration(ConfigSource configSource, ContainerRegistrationCollection customDependencies, ContainerRegistrationCollection generatorCustomDependencies, CultureInfo featureLanguage, CultureInfo bindingCulture, string unitTestProvider, bool stopAtFirstError, MissingOrPendingStepsOutcome missingOrPendingStepsOutcome, bool traceSuccessfulSteps, bool traceTimings, TimeSpan minTracedDuration, StepDefinitionSkeletonStyle stepDefinitionSkeletonStyle, List<string> additionalStepAssemblies, List<PluginDescriptor> pluginDescriptors, bool allowDebugGeneratedFiles, bool allowRowTests, bool markFeaturesParallelizable, string[] skipParallelizableMarkerForTags, ObsoleteBehavior obsoleteBehavior);

        public List<PluginDescriptor> Plugins { get; set; }
        public List<string> AdditionalStepAssemblies { get; set; }
        public StepDefinitionSkeletonStyle StepDefinitionSkeletonStyle { get; set; }
        public TimeSpan MinTracedDuration { get; set; }
        public bool TraceTimings { get; set; }
        public bool TraceSuccessfulSteps { get; set; }
        public ObsoleteBehavior ObsoleteBehavior { get; set; }
        public bool AllowRowTests { get; set; }
        public bool AllowDebugGeneratedFiles { get; set; }
        public MissingOrPendingStepsOutcome MissingOrPendingStepsOutcome { get; set; }
        public bool StopAtFirstError { get; set; }
        public string UnitTestProvider { get; set; }
        public CultureInfo BindingCulture { get; set; }
        public CultureInfo FeatureLanguage { get; set; }
        public ContainerRegistrationCollection GeneratorCustomDependencies { get; set; }
        public ContainerRegistrationCollection CustomDependencies { get; set; }
        public ConfigSource ConfigSource { get; set; }
        public bool MarkFeaturesParallelizable { get; set; }
        public string[] SkipParallelizableMarkerForTags { get; set; }

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern IEnumerable<PluginDescriptor> GetPlugins();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override bool Equals(object obj);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override int GetHashCode();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern bool Equals(SpecFlowConfiguration other);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}