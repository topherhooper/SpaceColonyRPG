# Recent Changes (Auto-generated)
Generated: 2025-07-13 13:34:38

## Modified Files
.ai-templates/NetworkedClass.template
.ai-templates/Singleton.template
.ai-templates/new_feature.md
.ai/architecture.md
.ai/conventions.md
.ai/conventions/git_strategy.md
.ai/current_sprint.md
.ai/debug_context.md
.ai/knowledge/common_errors.md
.ai/knowledge/git_patterns.md
.ai/knowledge/mirror_patterns.md
.ai/knowledge/performance_tips.md
.ai/knowledge/unity_gotchas.md
.ai/review_checklist.md
.ai/scripts/analyze_commits.sh
.ai/scripts/daily_report.sh
.ai/scripts/setup_git_integration.sh
.ai/start_session.md
.ai/workflows/daily_git_workflow.md
.ai/workflows/git_debugging.md
.claudeignore
.config/dotnet-tools.json
Assets/Mirror/Authenticators.meta
Assets/Mirror/Authenticators/BasicAuthenticator.cs
Assets/Mirror/Authenticators/BasicAuthenticator.cs.meta
Assets/Mirror/Authenticators/DeviceAuthenticator.cs
Assets/Mirror/Authenticators/DeviceAuthenticator.cs.meta
Assets/Mirror/Authenticators/Mirror.Authenticators.asmdef
Assets/Mirror/Authenticators/Mirror.Authenticators.asmdef.meta
Assets/Mirror/Authenticators/TimeoutAuthenticator.cs
Assets/Mirror/Authenticators/TimeoutAuthenticator.cs.meta
Assets/Mirror/CompilerSymbols.meta
Assets/Mirror/CompilerSymbols/Mirror.CompilerSymbols.asmdef
Assets/Mirror/CompilerSymbols/Mirror.CompilerSymbols.asmdef.meta
Assets/Mirror/CompilerSymbols/PreprocessorDefine.cs
Assets/Mirror/CompilerSymbols/PreprocessorDefine.cs.meta
Assets/Mirror/Components.meta
Assets/Mirror/Components/AssemblyInfo.cs
Assets/Mirror/Components/AssemblyInfo.cs.meta
Assets/Mirror/Components/Discovery.meta
Assets/Mirror/Components/Discovery/NetworkDiscovery.cs
Assets/Mirror/Components/Discovery/NetworkDiscovery.cs.meta
Assets/Mirror/Components/Discovery/NetworkDiscoveryBase.cs
Assets/Mirror/Components/Discovery/NetworkDiscoveryBase.cs.meta
Assets/Mirror/Components/Discovery/NetworkDiscoveryHUD.cs
Assets/Mirror/Components/Discovery/NetworkDiscoveryHUD.cs.meta
Assets/Mirror/Components/Discovery/ServerRequest.cs
Assets/Mirror/Components/Discovery/ServerRequest.cs.meta
Assets/Mirror/Components/Discovery/ServerResponse.cs
Assets/Mirror/Components/Discovery/ServerResponse.cs.meta
Assets/Mirror/Components/GUIConsole.cs
Assets/Mirror/Components/GUIConsole.cs.meta
Assets/Mirror/Components/InterestManagement.meta
Assets/Mirror/Components/InterestManagement/Distance.meta
Assets/Mirror/Components/InterestManagement/Distance/DistanceInterestManagement.cs
Assets/Mirror/Components/InterestManagement/Distance/DistanceInterestManagement.cs.meta
Assets/Mirror/Components/InterestManagement/Distance/DistanceInterestManagementCustomRange.cs
Assets/Mirror/Components/InterestManagement/Distance/DistanceInterestManagementCustomRange.cs.meta
Assets/Mirror/Components/InterestManagement/Match.meta
Assets/Mirror/Components/InterestManagement/Match/MatchInterestManagement.cs
Assets/Mirror/Components/InterestManagement/Match/MatchInterestManagement.cs.meta
Assets/Mirror/Components/InterestManagement/Match/NetworkMatch.cs
Assets/Mirror/Components/InterestManagement/Match/NetworkMatch.cs.meta
Assets/Mirror/Components/InterestManagement/Scene.meta
Assets/Mirror/Components/InterestManagement/Scene/SceneInterestManagement.cs
Assets/Mirror/Components/InterestManagement/Scene/SceneInterestManagement.cs.meta
Assets/Mirror/Components/InterestManagement/SceneDistance.meta
Assets/Mirror/Components/InterestManagement/SceneDistance/SceneDistanceInterestManagement.cs
Assets/Mirror/Components/InterestManagement/SceneDistance/SceneDistanceInterestManagement.cs.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing/Grid2D.cs
Assets/Mirror/Components/InterestManagement/SpatialHashing/Grid2D.cs.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing/Grid3D.cs
Assets/Mirror/Components/InterestManagement/SpatialHashing/Grid3D.cs.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing/HexGrid2D.cs
Assets/Mirror/Components/InterestManagement/SpatialHashing/HexGrid2D.cs.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing/HexGrid3D.cs
Assets/Mirror/Components/InterestManagement/SpatialHashing/HexGrid3D.cs.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing/HexSpatialHash2DInterestManagement.cs
Assets/Mirror/Components/InterestManagement/SpatialHashing/HexSpatialHash2DInterestManagement.cs.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing/HexSpatialHash3DInterestManagement.cs
Assets/Mirror/Components/InterestManagement/SpatialHashing/HexSpatialHash3DInterestManagement.cs.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing/SpatialHashing3DInterestManagement.cs
Assets/Mirror/Components/InterestManagement/SpatialHashing/SpatialHashing3DInterestManagement.cs.meta
Assets/Mirror/Components/InterestManagement/SpatialHashing/SpatialHashingInterestManagement.cs
Assets/Mirror/Components/InterestManagement/SpatialHashing/SpatialHashingInterestManagement.cs.meta
Assets/Mirror/Components/InterestManagement/Team.meta
Assets/Mirror/Components/InterestManagement/Team/NetworkTeam.cs
Assets/Mirror/Components/InterestManagement/Team/NetworkTeam.cs.meta
Assets/Mirror/Components/InterestManagement/Team/TeamInterestManagement.cs
Assets/Mirror/Components/InterestManagement/Team/TeamInterestManagement.cs.meta
Assets/Mirror/Components/LagCompensation.meta
Assets/Mirror/Components/LagCompensation/HistoryCollider.cs
Assets/Mirror/Components/LagCompensation/HistoryCollider.cs.meta
Assets/Mirror/Components/LagCompensation/LagCompensator.cs
Assets/Mirror/Components/LagCompensation/LagCompensator.cs.meta
Assets/Mirror/Components/Mirror.Components.asmdef
Assets/Mirror/Components/Mirror.Components.asmdef.meta
Assets/Mirror/Components/NetworkAnimator.cs
Assets/Mirror/Components/NetworkAnimator.cs.meta
Assets/Mirror/Components/NetworkDiagnosticsDebugger.cs
Assets/Mirror/Components/NetworkDiagnosticsDebugger.cs.meta
Assets/Mirror/Components/NetworkLobbyManager.cs
Assets/Mirror/Components/NetworkLobbyManager.cs.meta
Assets/Mirror/Components/NetworkLobbyPlayer.cs
Assets/Mirror/Components/NetworkLobbyPlayer.cs.meta
Assets/Mirror/Components/NetworkPingDisplay.cs
Assets/Mirror/Components/NetworkPingDisplay.cs.meta
Assets/Mirror/Components/NetworkRigidbody.meta
Assets/Mirror/Components/NetworkRigidbody/NetworkRigidbodyReliable.cs
Assets/Mirror/Components/NetworkRigidbody/NetworkRigidbodyReliable.cs.meta
Assets/Mirror/Components/NetworkRigidbody/NetworkRigidbodyReliable2D.cs
Assets/Mirror/Components/NetworkRigidbody/NetworkRigidbodyReliable2D.cs.meta
Assets/Mirror/Components/NetworkRigidbody/NetworkRigidbodyUnreliable.cs
Assets/Mirror/Components/NetworkRigidbody/NetworkRigidbodyUnreliable.cs.meta
Assets/Mirror/Components/NetworkRigidbody/NetworkRigidbodyUnreliable2D.cs
Assets/Mirror/Components/NetworkRigidbody/NetworkRigidbodyUnreliable2D.cs.meta
Assets/Mirror/Components/NetworkRoomManager.cs
Assets/Mirror/Components/NetworkRoomManager.cs.meta
Assets/Mirror/Components/NetworkRoomPlayer.cs
Assets/Mirror/Components/NetworkRoomPlayer.cs.meta
Assets/Mirror/Components/NetworkStatistics.cs
Assets/Mirror/Components/NetworkStatistics.cs.meta
Assets/Mirror/Components/NetworkTransform.meta
Assets/Mirror/Components/NetworkTransform/NetworkTransformBase.cs
Assets/Mirror/Components/NetworkTransform/NetworkTransformBase.cs.meta
Assets/Mirror/Components/NetworkTransform/NetworkTransformHybrid.cs
Assets/Mirror/Components/NetworkTransform/NetworkTransformHybrid.cs.meta
Assets/Mirror/Components/NetworkTransform/NetworkTransformReliable.cs
Assets/Mirror/Components/NetworkTransform/NetworkTransformReliable.cs.meta
Assets/Mirror/Components/NetworkTransform/NetworkTransformUnreliable.cs
Assets/Mirror/Components/NetworkTransform/NetworkTransformUnreliable.cs.meta
Assets/Mirror/Components/NetworkTransform/TransformSnapshot.cs
Assets/Mirror/Components/NetworkTransform/TransformSnapshot.cs.meta
Assets/Mirror/Components/NetworkTransform/TransformSyncData.cs
Assets/Mirror/Components/NetworkTransform/TransformSyncData.cs.meta
Assets/Mirror/Components/PredictedRigidbody.meta
Assets/Mirror/Components/PredictedRigidbody/LocalGhostMaterial.mat
Assets/Mirror/Components/PredictedRigidbody/LocalGhostMaterial.mat.meta
Assets/Mirror/Components/PredictedRigidbody/PredictedRigidbody.cs
Assets/Mirror/Components/PredictedRigidbody/PredictedRigidbody.cs.meta
Assets/Mirror/Components/PredictedRigidbody/PredictedRigidbodyPhysicsGhost.cs
Assets/Mirror/Components/PredictedRigidbody/PredictedRigidbodyPhysicsGhost.cs.meta
Assets/Mirror/Components/PredictedRigidbody/PredictedRigidbodyRemoteGhost.cs
Assets/Mirror/Components/PredictedRigidbody/PredictedRigidbodyRemoteGhost.cs.meta
Assets/Mirror/Components/PredictedRigidbody/PredictedSyncData.cs
Assets/Mirror/Components/PredictedRigidbody/PredictedSyncData.cs.meta
Assets/Mirror/Components/PredictedRigidbody/PredictionUtils.cs
Assets/Mirror/Components/PredictedRigidbody/PredictionUtils.cs.meta
Assets/Mirror/Components/PredictedRigidbody/RemoteGhostMaterial.mat
Assets/Mirror/Components/PredictedRigidbody/RemoteGhostMaterial.mat.meta
Assets/Mirror/Components/PredictedRigidbody/RigidbodyState.cs
Assets/Mirror/Components/PredictedRigidbody/RigidbodyState.cs.meta
Assets/Mirror/Components/Profiling.meta
Assets/Mirror/Components/Profiling/BaseUIGraph.cs
Assets/Mirror/Components/Profiling/BaseUIGraph.cs.meta
Assets/Mirror/Components/Profiling/FpsMinMaxAvgGraph.cs
Assets/Mirror/Components/Profiling/FpsMinMaxAvgGraph.cs.meta
Assets/Mirror/Components/Profiling/LineGraph.mat
Assets/Mirror/Components/Profiling/LineGraph.mat.meta
Assets/Mirror/Components/Profiling/NetworkBandwidthGraph.cs
Assets/Mirror/Components/Profiling/NetworkBandwidthGraph.cs.meta
Assets/Mirror/Components/Profiling/NetworkGraphLines.shader
Assets/Mirror/Components/Profiling/NetworkGraphLines.shader.meta
Assets/Mirror/Components/Profiling/NetworkGraphStacked.shader
Assets/Mirror/Components/Profiling/NetworkGraphStacked.shader.meta
Assets/Mirror/Components/Profiling/NetworkPingGraph.cs
Assets/Mirror/Components/Profiling/NetworkPingGraph.cs.meta
Assets/Mirror/Components/Profiling/NetworkRuntimeProfiler.cs
Assets/Mirror/Components/Profiling/NetworkRuntimeProfiler.cs.meta
Assets/Mirror/Components/Profiling/Prefabs.meta
Assets/Mirror/Components/Profiling/Prefabs/BandwidthGraph.prefab
Assets/Mirror/Components/Profiling/Prefabs/BandwidthGraph.prefab.meta
Assets/Mirror/Components/Profiling/Prefabs/FPSMinMaxAvg.prefab
Assets/Mirror/Components/Profiling/Prefabs/FPSMinMaxAvg.prefab.meta
Assets/Mirror/Components/Profiling/Prefabs/GraphCanvas.prefab
Assets/Mirror/Components/Profiling/Prefabs/GraphCanvas.prefab.meta
Assets/Mirror/Components/Profiling/Prefabs/NetworkGraph.prefab
Assets/Mirror/Components/Profiling/Prefabs/NetworkGraph.prefab.meta
Assets/Mirror/Components/Profiling/Prefabs/PingGraph.prefab
Assets/Mirror/Components/Profiling/Prefabs/PingGraph.prefab.meta
Assets/Mirror/Components/Profiling/StackedGraph.mat
Assets/Mirror/Components/Profiling/StackedGraph.mat.meta
Assets/Mirror/Components/Profiling/ToggleHotkey.cs
Assets/Mirror/Components/Profiling/ToggleHotkey.cs.meta
Assets/Mirror/Components/RemoteStatistics.cs
Assets/Mirror/Components/RemoteStatistics.cs.meta
Assets/Mirror/Core.meta
Assets/Mirror/Core/AssemblyInfo.cs
Assets/Mirror/Core/AssemblyInfo.cs.meta
Assets/Mirror/Core/Attributes.cs
Assets/Mirror/Core/Attributes.cs.meta
Assets/Mirror/Core/Batching.meta
Assets/Mirror/Core/Batching/Batcher.cs
Assets/Mirror/Core/Batching/Batcher.cs.meta
Assets/Mirror/Core/Batching/Unbatcher.cs
Assets/Mirror/Core/Batching/Unbatcher.cs.meta
Assets/Mirror/Core/ConnectionQuality.cs
Assets/Mirror/Core/ConnectionQuality.cs.meta
Assets/Mirror/Core/HostMode.cs
Assets/Mirror/Core/HostMode.cs.meta
Assets/Mirror/Core/InterestManagement.cs
Assets/Mirror/Core/InterestManagement.cs.meta
Assets/Mirror/Core/InterestManagementBase.cs
Assets/Mirror/Core/InterestManagementBase.cs.meta
Assets/Mirror/Core/LagCompensation.meta
Assets/Mirror/Core/LagCompensation/Capture.cs
Assets/Mirror/Core/LagCompensation/Capture.cs.meta
Assets/Mirror/Core/LagCompensation/HistoryBounds.cs
Assets/Mirror/Core/LagCompensation/HistoryBounds.cs.meta
Assets/Mirror/Core/LagCompensation/LagCompensation.cs
Assets/Mirror/Core/LagCompensation/LagCompensation.cs.meta
Assets/Mirror/Core/LagCompensation/LagCompensationSettings.cs
Assets/Mirror/Core/LagCompensation/LagCompensationSettings.cs.meta
Assets/Mirror/Core/LagCompensation/MinMaxBounds.cs
Assets/Mirror/Core/LagCompensation/MinMaxBounds.cs.meta
Assets/Mirror/Core/LocalConnectionToClient.cs
Assets/Mirror/Core/LocalConnectionToClient.cs.meta
Assets/Mirror/Core/LocalConnectionToServer.cs
Assets/Mirror/Core/LocalConnectionToServer.cs.meta
Assets/Mirror/Core/Messages.cs
Assets/Mirror/Core/Messages.cs.meta
Assets/Mirror/Core/Mirror.asmdef
Assets/Mirror/Core/Mirror.asmdef.meta
Assets/Mirror/Core/NetworkAuthenticator.cs
Assets/Mirror/Core/NetworkAuthenticator.cs.meta
Assets/Mirror/Core/NetworkBehaviour.cs
Assets/Mirror/Core/NetworkBehaviour.cs.meta
Assets/Mirror/Core/NetworkBehaviourHybrid.cs
Assets/Mirror/Core/NetworkBehaviourHybrid.cs.meta
Assets/Mirror/Core/NetworkBehaviourSyncVar.cs
Assets/Mirror/Core/NetworkBehaviourSyncVar.cs.meta
Assets/Mirror/Core/NetworkClient.cs
Assets/Mirror/Core/NetworkClient.cs.meta
Assets/Mirror/Core/NetworkClient_TimeInterpolation.cs
Assets/Mirror/Core/NetworkClient_TimeInterpolation.cs.meta
Assets/Mirror/Core/NetworkConnection.cs
Assets/Mirror/Core/NetworkConnection.cs.meta
Assets/Mirror/Core/NetworkConnectionToClient.cs
Assets/Mirror/Core/NetworkConnectionToClient.cs.meta
Assets/Mirror/Core/NetworkConnectionToServer.cs
Assets/Mirror/Core/NetworkConnectionToServer.cs.meta
Assets/Mirror/Core/NetworkDiagnostics.cs
Assets/Mirror/Core/NetworkDiagnostics.cs.meta
Assets/Mirror/Core/NetworkIdentity.cs
Assets/Mirror/Core/NetworkIdentity.cs.meta
Assets/Mirror/Core/NetworkLoop.cs
Assets/Mirror/Core/NetworkLoop.cs.meta
Assets/Mirror/Core/NetworkManager.cs
Assets/Mirror/Core/NetworkManager.cs.meta
Assets/Mirror/Core/NetworkManagerHUD.cs
Assets/Mirror/Core/NetworkManagerHUD.cs.meta
Assets/Mirror/Core/NetworkMessage.cs
Assets/Mirror/Core/NetworkMessage.cs.meta
Assets/Mirror/Core/NetworkMessages.cs
Assets/Mirror/Core/NetworkMessages.cs.meta
Assets/Mirror/Core/NetworkReader.cs
Assets/Mirror/Core/NetworkReader.cs.meta
Assets/Mirror/Core/NetworkReaderExtensions.cs
Assets/Mirror/Core/NetworkReaderExtensions.cs.meta
Assets/Mirror/Core/NetworkReaderPool.cs
Assets/Mirror/Core/NetworkReaderPool.cs.meta
Assets/Mirror/Core/NetworkReaderPooled.cs
Assets/Mirror/Core/NetworkReaderPooled.cs.meta
Assets/Mirror/Core/NetworkServer.cs
Assets/Mirror/Core/NetworkServer.cs.meta
Assets/Mirror/Core/NetworkStartPosition.cs
Assets/Mirror/Core/NetworkStartPosition.cs.meta
Assets/Mirror/Core/NetworkTime.cs
Assets/Mirror/Core/NetworkTime.cs.meta
Assets/Mirror/Core/NetworkWriter.cs
Assets/Mirror/Core/NetworkWriter.cs.meta
Assets/Mirror/Core/NetworkWriterExtensions.cs
Assets/Mirror/Core/NetworkWriterExtensions.cs.meta
Assets/Mirror/Core/NetworkWriterPool.cs
Assets/Mirror/Core/NetworkWriterPool.cs.meta
Assets/Mirror/Core/NetworkWriterPooled.cs
Assets/Mirror/Core/NetworkWriterPooled.cs.meta
Assets/Mirror/Core/PortTransport.cs
Assets/Mirror/Core/PortTransport.cs.meta
Assets/Mirror/Core/Prediction.meta
Assets/Mirror/Core/Prediction/Prediction.cs
Assets/Mirror/Core/Prediction/Prediction.cs.meta
Assets/Mirror/Core/RemoteCalls.cs
Assets/Mirror/Core/RemoteCalls.cs.meta
Assets/Mirror/Core/SnapshotInterpolation.meta
Assets/Mirror/Core/SnapshotInterpolation/Snapshot.cs
Assets/Mirror/Core/SnapshotInterpolation/Snapshot.cs.meta
Assets/Mirror/Core/SnapshotInterpolation/SnapshotInterpolation.cs
Assets/Mirror/Core/SnapshotInterpolation/SnapshotInterpolation.cs.meta
Assets/Mirror/Core/SnapshotInterpolation/SnapshotInterpolationSettings.cs
Assets/Mirror/Core/SnapshotInterpolation/SnapshotInterpolationSettings.cs.meta
Assets/Mirror/Core/SnapshotInterpolation/TimeSnapshot.cs
Assets/Mirror/Core/SnapshotInterpolation/TimeSnapshot.cs.meta
Assets/Mirror/Core/SyncDictionary.cs
Assets/Mirror/Core/SyncDictionary.cs.meta
Assets/Mirror/Core/SyncList.cs
Assets/Mirror/Core/SyncList.cs.meta
Assets/Mirror/Core/SyncObject.cs
Assets/Mirror/Core/SyncObject.cs.meta
Assets/Mirror/Core/SyncSet.cs
Assets/Mirror/Core/SyncSet.cs.meta
Assets/Mirror/Core/Threading.meta
Assets/Mirror/Core/Threading/ConcurrentNetworkWriterPool.cs
Assets/Mirror/Core/Threading/ConcurrentNetworkWriterPool.cs.meta
Assets/Mirror/Core/Threading/ConcurrentNetworkWriterPooled.cs
Assets/Mirror/Core/Threading/ConcurrentNetworkWriterPooled.cs.meta
Assets/Mirror/Core/Threading/ConcurrentPool.cs
Assets/Mirror/Core/Threading/ConcurrentPool.cs.meta
Assets/Mirror/Core/Threading/ThreadLog.cs
Assets/Mirror/Core/Threading/ThreadLog.cs.meta
Assets/Mirror/Core/Threading/WorkerThread.cs
Assets/Mirror/Core/Threading/WorkerThread.cs.meta
Assets/Mirror/Core/Tools.meta
Assets/Mirror/Core/Tools/AccurateInterval.cs
Assets/Mirror/Core/Tools/AccurateInterval.cs.meta
Assets/Mirror/Core/Tools/Compression.cs
Assets/Mirror/Core/Tools/Compression.cs.meta
Assets/Mirror/Core/Tools/DeltaCompression.cs
Assets/Mirror/Core/Tools/DeltaCompression.cs.meta
Assets/Mirror/Core/Tools/ExponentialMovingAverage.cs
Assets/Mirror/Core/Tools/ExponentialMovingAverage.cs.meta
Assets/Mirror/Core/Tools/Extensions.cs
Assets/Mirror/Core/Tools/Extensions.cs.meta
Assets/Mirror/Core/Tools/Half.cs
Assets/Mirror/Core/Tools/Half.cs.meta
Assets/Mirror/Core/Tools/Mathd.cs
Assets/Mirror/Core/Tools/Mathd.cs.meta
Assets/Mirror/Core/Tools/Pool.cs
Assets/Mirror/Core/Tools/Pool.cs.meta
Assets/Mirror/Core/Tools/Readme.txt
Assets/Mirror/Core/Tools/Readme.txt.meta
Assets/Mirror/Core/Tools/TimeSample.cs
Assets/Mirror/Core/Tools/TimeSample.cs.meta
Assets/Mirror/Core/Tools/Utils.cs
Assets/Mirror/Core/Tools/Utils.cs.meta
Assets/Mirror/Core/Tools/Vector3Long.cs
Assets/Mirror/Core/Tools/Vector3Long.cs.meta
Assets/Mirror/Core/Tools/Vector4Long.cs
Assets/Mirror/Core/Tools/Vector4Long.cs.meta
Assets/Mirror/Core/Transport.cs
Assets/Mirror/Core/Transport.cs.meta
Assets/Mirror/Core/TransportError.cs
Assets/Mirror/Core/TransportError.cs.meta
Assets/Mirror/Core/WeaverFuse.cs
Assets/Mirror/Core/WeaverFuse.cs.meta
Assets/Mirror/Editor.meta
Assets/Mirror/Editor/AndroidManifestHelper.cs
Assets/Mirror/Editor/AndroidManifestHelper.cs.meta
Assets/Mirror/Editor/EditorHelper.cs
Assets/Mirror/Editor/EditorHelper.cs.meta
Assets/Mirror/Editor/Icon.meta
Assets/Mirror/Editor/Icon/MirrorIcon.png
Assets/Mirror/Editor/Icon/MirrorIcon.png.meta
Assets/Mirror/Editor/InspectorHelper.cs
Assets/Mirror/Editor/InspectorHelper.cs.meta
Assets/Mirror/Editor/LagCompensatorInspector.cs
Assets/Mirror/Editor/LagCompensatorInspector.cs.meta
Assets/Mirror/Editor/Mirror.Editor.asmdef
Assets/Mirror/Editor/Mirror.Editor.asmdef.meta
Assets/Mirror/Editor/NetworkBehaviourInspector.cs
Assets/Mirror/Editor/NetworkBehaviourInspector.cs.meta
Assets/Mirror/Editor/NetworkInformationPreview.cs
Assets/Mirror/Editor/NetworkInformationPreview.cs.meta
Assets/Mirror/Editor/NetworkManagerEditor.cs
Assets/Mirror/Editor/NetworkManagerEditor.cs.meta
Assets/Mirror/Editor/NetworkScenePostProcess.cs
Assets/Mirror/Editor/NetworkScenePostProcess.cs.meta
Assets/Mirror/Editor/ReadOnlyDrawer.cs
Assets/Mirror/Editor/ReadOnlyDrawer.cs.meta
Assets/Mirror/Editor/SceneDrawer.cs
Assets/Mirror/Editor/SceneDrawer.cs.meta
Assets/Mirror/Editor/SyncObjectCollectionsDrawer.cs
Assets/Mirror/Editor/SyncObjectCollectionsDrawer.cs.meta
Assets/Mirror/Editor/SyncVarAttributeDrawer.cs
Assets/Mirror/Editor/SyncVarAttributeDrawer.cs.meta
Assets/Mirror/Editor/Weaver.meta
Assets/Mirror/Editor/Weaver/AssemblyInfo.cs
Assets/Mirror/Editor/Weaver/AssemblyInfo.cs.meta
Assets/Mirror/Editor/Weaver/EntryPoint.meta
Assets/Mirror/Editor/Weaver/EntryPoint/CompilationFinishedHook.cs
Assets/Mirror/Editor/Weaver/EntryPoint/CompilationFinishedHook.cs.meta
Assets/Mirror/Editor/Weaver/EntryPoint/CompilationFinishedLogger.cs
Assets/Mirror/Editor/Weaver/EntryPoint/CompilationFinishedLogger.cs.meta
Assets/Mirror/Editor/Weaver/EntryPoint/EnterPlayModeHook.cs
Assets/Mirror/Editor/Weaver/EntryPoint/EnterPlayModeHook.cs.meta
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor.meta
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/CompiledAssemblyFromFile.cs
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/CompiledAssemblyFromFile.cs.meta
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorAssemblyResolver.cs
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorAssemblyResolver.cs.meta
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorFromFile.cs
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorFromFile.cs.meta
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorHook.cs
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorHook.cs.meta
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorLogger.cs
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorLogger.cs.meta
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorReflectionImporter.cs
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorReflectionImporter.cs.meta
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorReflectionImporterProvider.cs
Assets/Mirror/Editor/Weaver/EntryPointILPostProcessor/ILPostProcessorReflectionImporterProvider.cs.meta
Assets/Mirror/Editor/Weaver/Extensions.cs
Assets/Mirror/Editor/Weaver/Extensions.cs.meta
Assets/Mirror/Editor/Weaver/Helpers.cs
Assets/Mirror/Editor/Weaver/Helpers.cs.meta
Assets/Mirror/Editor/Weaver/Logger.cs
Assets/Mirror/Editor/Weaver/Logger.cs.meta
Assets/Mirror/Editor/Weaver/Processors.meta
Assets/Mirror/Editor/Weaver/Processors/CommandProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/CommandProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/MethodProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/MethodProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/MonoBehaviourProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/MonoBehaviourProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/NetworkBehaviourProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/NetworkBehaviourProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/ReaderWriterProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/ReaderWriterProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/RpcProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/RpcProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/ServerClientAttributeProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/ServerClientAttributeProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/SyncObjectInitializer.cs
Assets/Mirror/Editor/Weaver/Processors/SyncObjectInitializer.cs.meta
Assets/Mirror/Editor/Weaver/Processors/SyncObjectProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/SyncObjectProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/SyncVarAttributeAccessReplacer.cs
Assets/Mirror/Editor/Weaver/Processors/SyncVarAttributeAccessReplacer.cs.meta
Assets/Mirror/Editor/Weaver/Processors/SyncVarAttributeProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/SyncVarAttributeProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Processors/TargetRpcProcessor.cs
Assets/Mirror/Editor/Weaver/Processors/TargetRpcProcessor.cs.meta
Assets/Mirror/Editor/Weaver/Readers.cs
Assets/Mirror/Editor/Weaver/Readers.cs.meta
Assets/Mirror/Editor/Weaver/Resolvers.cs
Assets/Mirror/Editor/Weaver/Resolvers.cs.meta
Assets/Mirror/Editor/Weaver/SyncVarAccessLists.cs
Assets/Mirror/Editor/Weaver/SyncVarAccessLists.cs.meta
Assets/Mirror/Editor/Weaver/TypeReferenceComparer.cs
Assets/Mirror/Editor/Weaver/TypeReferenceComparer.cs.meta
Assets/Mirror/Editor/Weaver/Unity.Mirror.CodeGen.asmdef
Assets/Mirror/Editor/Weaver/Unity.Mirror.CodeGen.asmdef.meta
Assets/Mirror/Editor/Weaver/Weaver.cs
Assets/Mirror/Editor/Weaver/Weaver.cs.meta
Assets/Mirror/Editor/Weaver/WeaverExceptions.cs
Assets/Mirror/Editor/Weaver/WeaverExceptions.cs.meta
Assets/Mirror/Editor/Weaver/WeaverTypes.cs
Assets/Mirror/Editor/Weaver/WeaverTypes.cs.meta
Assets/Mirror/Editor/Weaver/Writers.cs
Assets/Mirror/Editor/Weaver/Writers.cs.meta
Assets/Mirror/Editor/Welcome.cs
Assets/Mirror/Editor/Welcome.cs.meta
Assets/Mirror/Examples.meta
Assets/Mirror/Examples/AdditiveLevels.meta
Assets/Mirror/Examples/AdditiveLevels/Materials.meta
Assets/Mirror/Examples/AdditiveLevels/Materials/CubeSphere.mat
Assets/Mirror/Examples/AdditiveLevels/Materials/CubeSphere.mat.meta
Assets/Mirror/Examples/AdditiveLevels/Materials/Ground.mat
Assets/Mirror/Examples/AdditiveLevels/Materials/Ground.mat.meta
Assets/Mirror/Examples/AdditiveLevels/Materials/Player.mat
Assets/Mirror/Examples/AdditiveLevels/Materials/Player.mat.meta
Assets/Mirror/Examples/AdditiveLevels/Materials/Portal.mat
Assets/Mirror/Examples/AdditiveLevels/Materials/Portal.mat.meta
Assets/Mirror/Examples/AdditiveLevels/Materials/Skybox.mat
Assets/Mirror/Examples/AdditiveLevels/Materials/Skybox.mat.meta
Assets/Mirror/Examples/AdditiveLevels/Materials/StartPoint.mat
Assets/Mirror/Examples/AdditiveLevels/Materials/StartPoint.mat.meta
Assets/Mirror/Examples/AdditiveLevels/Prefabs.meta
Assets/Mirror/Examples/AdditiveLevels/Prefabs/Cube.prefab
Assets/Mirror/Examples/AdditiveLevels/Prefabs/Cube.prefab.meta
Assets/Mirror/Examples/AdditiveLevels/Prefabs/Plane.prefab
Assets/Mirror/Examples/AdditiveLevels/Prefabs/Plane.prefab.meta
Assets/Mirror/Examples/AdditiveLevels/Prefabs/PlayerReliable.prefab
Assets/Mirror/Examples/AdditiveLevels/Prefabs/PlayerReliable.prefab.meta
Assets/Mirror/Examples/AdditiveLevels/Prefabs/PlayerUnreliable.prefab
Assets/Mirror/Examples/AdditiveLevels/Prefabs/PlayerUnreliable.prefab.meta
Assets/Mirror/Examples/AdditiveLevels/Prefabs/Portal.prefab
Assets/Mirror/Examples/AdditiveLevels/Prefabs/Portal.prefab.meta
Assets/Mirror/Examples/AdditiveLevels/Prefabs/Sphere.prefab
Assets/Mirror/Examples/AdditiveLevels/Prefabs/Sphere.prefab.meta
Assets/Mirror/Examples/AdditiveLevels/Prefabs/StartPoint.prefab
Assets/Mirror/Examples/AdditiveLevels/Prefabs/StartPoint.prefab.meta
Assets/Mirror/Examples/AdditiveLevels/ReadMe.txt
Assets/Mirror/Examples/AdditiveLevels/ReadMe.txt.meta
Assets/Mirror/Examples/AdditiveLevels/Scenes.meta
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOffline.unity
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOffline.unity.meta
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOnline.meta
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOnline.unity
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOnline.unity.meta
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOnline/LightingData.asset
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOnline/LightingData.asset.meta
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOnline/ReflectionProbe-0.exr
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsOnline/ReflectionProbe-0.exr.meta
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsSubLevel1.unity
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsSubLevel1.unity.meta
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsSubLevel2.unity
Assets/Mirror/Examples/AdditiveLevels/Scenes/MirrorAdditiveLevelsSubLevel2.unity.meta
Assets/Mirror/Examples/AdditiveLevels/Scripts.meta
Assets/Mirror/Examples/AdditiveLevels/Scripts/AdditiveLevelsNetworkManager.cs
Assets/Mirror/Examples/AdditiveLevels/Scripts/AdditiveLevelsNetworkManager.cs.meta
Assets/Mirror/Examples/AdditiveLevels/Scripts/FadeInOut.cs
Assets/Mirror/Examples/AdditiveLevels/Scripts/FadeInOut.cs.meta
Assets/Mirror/Examples/AdditiveLevels/Scripts/LookAtMainCamera.cs
Assets/Mirror/Examples/AdditiveLevels/Scripts/LookAtMainCamera.cs.meta
Assets/Mirror/Examples/AdditiveLevels/Scripts/Portal.cs
Assets/Mirror/Examples/AdditiveLevels/Scripts/Portal.cs.meta
Assets/Mirror/Examples/AdditiveLevels/Textures.meta
Assets/Mirror/Examples/AdditiveLevels/Textures/Back_Tex.jpeg
Assets/Mirror/Examples/AdditiveLevels/Textures/Back_Tex.jpeg.meta
Assets/Mirror/Examples/AdditiveLevels/Textures/Down_Tex.jpeg
Assets/Mirror/Examples/AdditiveLevels/Textures/Down_Tex.jpeg.meta
Assets/Mirror/Examples/AdditiveLevels/Textures/Front_Tex.jpeg
Assets/Mirror/Examples/AdditiveLevels/Textures/Front_Tex.jpeg.meta
Assets/Mirror/Examples/AdditiveLevels/Textures/Left_Tex.jpeg
Assets/Mirror/Examples/AdditiveLevels/Textures/Left_Tex.jpeg.meta
Assets/Mirror/Examples/AdditiveLevels/Textures/Right_Tex.jpeg
Assets/Mirror/Examples/AdditiveLevels/Textures/Right_Tex.jpeg.meta
Assets/Mirror/Examples/AdditiveLevels/Textures/Up_Tex.jpeg
Assets/Mirror/Examples/AdditiveLevels/Textures/Up_Tex.jpeg.meta
Assets/Mirror/Examples/AdditiveScenes.meta
Assets/Mirror/Examples/AdditiveScenes/Materials.meta
Assets/Mirror/Examples/AdditiveScenes/Materials/Capsule.mat
Assets/Mirror/Examples/AdditiveScenes/Materials/Capsule.mat.meta
Assets/Mirror/Examples/AdditiveScenes/Materials/Cube.mat
Assets/Mirror/Examples/AdditiveScenes/Materials/Cube.mat.meta
Assets/Mirror/Examples/AdditiveScenes/Materials/Cylinder.mat
Assets/Mirror/Examples/AdditiveScenes/Materials/Cylinder.mat.meta
Assets/Mirror/Examples/AdditiveScenes/Materials/Player.mat
Assets/Mirror/Examples/AdditiveScenes/Materials/Player.mat.meta
Assets/Mirror/Examples/AdditiveScenes/Materials/Quad.mat
Assets/Mirror/Examples/AdditiveScenes/Materials/Quad.mat.meta
Assets/Mirror/Examples/AdditiveScenes/Materials/Shelter.mat
Assets/Mirror/Examples/AdditiveScenes/Materials/Shelter.mat.meta
Assets/Mirror/Examples/AdditiveScenes/Materials/Sphere.mat
Assets/Mirror/Examples/AdditiveScenes/Materials/Sphere.mat.meta
Assets/Mirror/Examples/AdditiveScenes/Materials/Zone.mat
Assets/Mirror/Examples/AdditiveScenes/Materials/Zone.mat.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Capsule.prefab
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Capsule.prefab.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Cube.prefab
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Cube.prefab.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Cylinder.prefab
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Cylinder.prefab.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs/PlayerReliable.prefab
Assets/Mirror/Examples/AdditiveScenes/Prefabs/PlayerReliable.prefab.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs/PlayerUnreliable.prefab
Assets/Mirror/Examples/AdditiveScenes/Prefabs/PlayerUnreliable.prefab.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Sphere.prefab
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Sphere.prefab.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Tank.prefab
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Tank.prefab.meta
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Zone.prefab
Assets/Mirror/Examples/AdditiveScenes/Prefabs/Zone.prefab.meta
Assets/Mirror/Examples/AdditiveScenes/README.md
Assets/Mirror/Examples/AdditiveScenes/README.md.meta
Assets/Mirror/Examples/AdditiveScenes/Scenes.meta
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesMain.meta
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesMain.unity
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesMain.unity.meta
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesMain/LightingData.asset
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesMain/LightingData.asset.meta
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesMain/ReflectionProbe-0.exr
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesMain/ReflectionProbe-0.exr.meta
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesSubScene.unity
Assets/Mirror/Examples/AdditiveScenes/Scenes/MirrorAdditiveScenesSubScene.unity.meta
Assets/Mirror/Examples/AdditiveScenes/Scripts.meta
Assets/Mirror/Examples/AdditiveScenes/Scripts/AdditiveNetworkManager.cs
Assets/Mirror/Examples/AdditiveScenes/Scripts/AdditiveNetworkManager.cs.meta
Assets/Mirror/Examples/AdditiveScenes/Scripts/ShootingTankBehaviour.cs
Assets/Mirror/Examples/AdditiveScenes/Scripts/ShootingTankBehaviour.cs.meta
Assets/Mirror/Examples/AdditiveScenes/Scripts/ZoneHandler.cs
Assets/Mirror/Examples/AdditiveScenes/Scripts/ZoneHandler.cs.meta
Assets/Mirror/Examples/AutoLANClientController.meta
Assets/Mirror/Examples/AutoLANClientController/MirrorAutoLANClientController.unity
Assets/Mirror/Examples/AutoLANClientController/MirrorAutoLANClientController.unity.meta
Assets/Mirror/Examples/AutoLANClientController/Prefabs.meta
Assets/Mirror/Examples/AutoLANClientController/Prefabs/PlayerController.prefab
Assets/Mirror/Examples/AutoLANClientController/Prefabs/PlayerController.prefab.meta
Assets/Mirror/Examples/AutoLANClientController/Scripts.meta
Assets/Mirror/Examples/AutoLANClientController/Scripts/AutoLANNetworkDiscovery.cs
Assets/Mirror/Examples/AutoLANClientController/Scripts/AutoLANNetworkDiscovery.cs.meta
Assets/Mirror/Examples/AutoLANClientController/Scripts/AutoLANNetworkManager.cs
Assets/Mirror/Examples/AutoLANClientController/Scripts/AutoLANNetworkManager.cs.meta
Assets/Mirror/Examples/AutoLANClientController/Scripts/CanvasHUD.cs
Assets/Mirror/Examples/AutoLANClientController/Scripts/CanvasHUD.cs.meta
Assets/Mirror/Examples/AutoLANClientController/Scripts/NetworkSceneScript.cs
Assets/Mirror/Examples/AutoLANClientController/Scripts/NetworkSceneScript.cs.meta
Assets/Mirror/Examples/Basic.meta
Assets/Mirror/Examples/Basic/Prefabs.meta
Assets/Mirror/Examples/Basic/Prefabs/Player.prefab
Assets/Mirror/Examples/Basic/Prefabs/Player.prefab.meta
Assets/Mirror/Examples/Basic/Prefabs/PlayerUI.prefab
Assets/Mirror/Examples/Basic/Prefabs/PlayerUI.prefab.meta
Assets/Mirror/Examples/Basic/README.md
Assets/Mirror/Examples/Basic/README.md.meta
Assets/Mirror/Examples/Basic/Scenes.meta
Assets/Mirror/Examples/Basic/Scenes/MirrorBasic.unity
Assets/Mirror/Examples/Basic/Scenes/MirrorBasic.unity.meta
Assets/Mirror/Examples/Basic/Scripts.meta
Assets/Mirror/Examples/Basic/Scripts/BasicNetManager.cs
Assets/Mirror/Examples/Basic/Scripts/BasicNetManager.cs.meta
Assets/Mirror/Examples/Basic/Scripts/CanvasUI.cs
Assets/Mirror/Examples/Basic/Scripts/CanvasUI.cs.meta
Assets/Mirror/Examples/Basic/Scripts/Player.cs
Assets/Mirror/Examples/Basic/Scripts/Player.cs.meta
Assets/Mirror/Examples/Basic/Scripts/PlayerUI.cs
Assets/Mirror/Examples/Basic/Scripts/PlayerUI.cs.meta
Assets/Mirror/Examples/Benchmark.meta
Assets/Mirror/Examples/Benchmark/Materials.meta
Assets/Mirror/Examples/Benchmark/Materials/Red.mat
Assets/Mirror/Examples/Benchmark/Materials/Red.mat.meta
Assets/Mirror/Examples/Benchmark/Materials/White.mat
Assets/Mirror/Examples/Benchmark/Materials/White.mat.meta
Assets/Mirror/Examples/Benchmark/Prefabs.meta
Assets/Mirror/Examples/Benchmark/Prefabs/Monster.prefab
Assets/Mirror/Examples/Benchmark/Prefabs/Monster.prefab.meta
Assets/Mirror/Examples/Benchmark/Prefabs/Player.prefab
Assets/Mirror/Examples/Benchmark/Prefabs/Player.prefab.meta
Assets/Mirror/Examples/Benchmark/Scenes.meta
Assets/Mirror/Examples/Benchmark/Scenes/MirrorBenchmark.unity
Assets/Mirror/Examples/Benchmark/Scenes/MirrorBenchmark.unity.meta
Assets/Mirror/Examples/Benchmark/Scripts.meta
Assets/Mirror/Examples/Benchmark/Scripts/BenchmarkNetworkManager.cs
Assets/Mirror/Examples/Benchmark/Scripts/BenchmarkNetworkManager.cs.meta
Assets/Mirror/Examples/Benchmark/Scripts/MonsterMovement.cs
Assets/Mirror/Examples/Benchmark/Scripts/MonsterMovement.cs.meta
Assets/Mirror/Examples/Benchmark/Scripts/PlayerMovement.cs
Assets/Mirror/Examples/Benchmark/Scripts/PlayerMovement.cs.meta
Assets/Mirror/Examples/BenchmarkIdle.meta
Assets/Mirror/Examples/BenchmarkIdle/BenchmarkIdleNetworkManager.cs
Assets/Mirror/Examples/BenchmarkIdle/BenchmarkIdleNetworkManager.cs.meta
Assets/Mirror/Examples/BenchmarkIdle/MirrorBenchmarkIdle.unity
Assets/Mirror/Examples/BenchmarkIdle/MirrorBenchmarkIdle.unity.meta
Assets/Mirror/Examples/BenchmarkIdle/Npc.cs
Assets/Mirror/Examples/BenchmarkIdle/Npc.cs.meta
Assets/Mirror/Examples/BenchmarkIdle/Npc.mat
Assets/Mirror/Examples/BenchmarkIdle/Npc.mat.meta
Assets/Mirror/Examples/BenchmarkIdle/Npc.prefab
Assets/Mirror/Examples/BenchmarkIdle/Npc.prefab.meta
Assets/Mirror/Examples/BenchmarkIdle/Player.cs
Assets/Mirror/Examples/BenchmarkIdle/Player.cs.meta
Assets/Mirror/Examples/BenchmarkIdle/Player.mat
Assets/Mirror/Examples/BenchmarkIdle/Player.mat.meta
Assets/Mirror/Examples/BenchmarkIdle/Player.prefab
Assets/Mirror/Examples/BenchmarkIdle/Player.prefab.meta
Assets/Mirror/Examples/BenchmarkIdle/Readme.txt
Assets/Mirror/Examples/BenchmarkIdle/Readme.txt.meta
Assets/Mirror/Examples/BenchmarkIdle/_Readme.txt
Assets/Mirror/Examples/BenchmarkIdle/_Readme.txt.meta
Assets/Mirror/Examples/BenchmarkPrediction.meta
Assets/Mirror/Examples/BenchmarkPrediction/BallMaterial.mat
Assets/Mirror/Examples/BenchmarkPrediction/BallMaterial.mat.meta
Assets/Mirror/Examples/BenchmarkPrediction/MirrorPredictionBenchmark.unity
Assets/Mirror/Examples/BenchmarkPrediction/MirrorPredictionBenchmark.unity.meta
Assets/Mirror/Examples/BenchmarkPrediction/NetworkManagerPredictionBenchmark.cs
Assets/Mirror/Examples/BenchmarkPrediction/NetworkManagerPredictionBenchmark.cs.meta
Assets/Mirror/Examples/BenchmarkPrediction/PlayerSpectator.prefab
Assets/Mirror/Examples/BenchmarkPrediction/PlayerSpectator.prefab.meta
Assets/Mirror/Examples/BenchmarkPrediction/PredictedBall.prefab
Assets/Mirror/Examples/BenchmarkPrediction/PredictedBall.prefab.meta
Assets/Mirror/Examples/BenchmarkPrediction/RandomForce.cs
Assets/Mirror/Examples/BenchmarkPrediction/RandomForce.cs.meta
Assets/Mirror/Examples/BenchmarkPrediction/Readme.md
Assets/Mirror/Examples/BenchmarkPrediction/Readme.md.meta
Assets/Mirror/Examples/BenchmarkPrediction/WallMaterial.mat
Assets/Mirror/Examples/BenchmarkPrediction/WallMaterial.mat.meta
Assets/Mirror/Examples/BenchmarkStinkySteak.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/BehaviourConfig.asset
Assets/Mirror/Examples/BenchmarkStinkySteak/BehaviourConfig.asset.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/LICENSE.md
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/LICENSE.md.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/README.md
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/README.md.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/Runtime.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/Runtime/PauseableSimulationTimer.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/Runtime/PauseableSimulationTimer.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/Runtime/SimulationTimer.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/Runtime/SimulationTimer.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/package.json
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/Unity-Simulation-Timer/package.json.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/LICENSE.md
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/LICENSE.md.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Config.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Config/DefaultBehaviourConfig.asset
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Config/DefaultBehaviourConfig.asset.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Prefabs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Prefabs/BaseGUIGame.prefab
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Prefabs/BaseGUIGame.prefab.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourConfig.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourConfig.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper/IMoveWrapper.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper/IMoveWrapper.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper/SinMoveYWrapper.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper/SinMoveYWrapper.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper/SinRandomMoveWrapper.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper/SinRandomMoveWrapper.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper/WanderMoveWrapper.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/BehaviourWrapper/WanderMoveWrapper.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/RandomVector3.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/RandomVector3.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/UI.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/UI/BaseGUIGame.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Scripts/UI/BaseGUIGame.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Shaders.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Shaders/Unlit.mat
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Shaders/Unlit.mat.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Shaders/Unlit.shader
Assets/Mirror/Examples/BenchmarkStinkySteak/Dependencies/netcode-benchmarker-util/Runtime/Shaders/Unlit.shader.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/LICENSE.md
Assets/Mirror/Examples/BenchmarkStinkySteak/LICENSE.md.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Main.unity
Assets/Mirror/Examples/BenchmarkStinkySteak/Main.unity.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/GUIGame.prefab
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/GUIGame.prefab.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/NetworkManager.prefab
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/NetworkManager.prefab.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/PlayerDummy.prefab
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/PlayerDummy.prefab.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/SphereMoveAllAxis.prefab
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/SphereMoveAllAxis.prefab.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/SphereMoveWander.prefab
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/SphereMoveWander.prefab.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/SphereMoveY.prefab
Assets/Mirror/Examples/BenchmarkStinkySteak/Prefabs/SphereMoveY.prefab.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts/GUIGame.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts/GUIGame.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts/SineMoveRandomBehaviour.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts/SineMoveRandomBehaviour.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts/SineMoveYBehaviour.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts/SineMoveYBehaviour.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts/WanderMoveBehaviour.cs
Assets/Mirror/Examples/BenchmarkStinkySteak/Scripts/WanderMoveBehaviour.cs.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Shaders.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Shaders/Unlit.mat
Assets/Mirror/Examples/BenchmarkStinkySteak/Shaders/Unlit.mat.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/Shaders/Unlit.shader
Assets/Mirror/Examples/BenchmarkStinkySteak/Shaders/Unlit.shader.meta
Assets/Mirror/Examples/BenchmarkStinkySteak/_Readme.txt
Assets/Mirror/Examples/BenchmarkStinkySteak/_Readme.txt.meta
Assets/Mirror/Examples/Billiards.meta
Assets/Mirror/Examples/Billiards/Ball.meta
Assets/Mirror/Examples/Billiards/Ball/Ball.physicMaterial
Assets/Mirror/Examples/Billiards/Ball/Ball.physicMaterial.meta
Assets/Mirror/Examples/Billiards/Ball/Red.mat
Assets/Mirror/Examples/Billiards/Ball/Red.mat.meta
Assets/Mirror/Examples/Billiards/Ball/Red.prefab
Assets/Mirror/Examples/Billiards/Ball/Red.prefab.meta
Assets/Mirror/Examples/Billiards/Ball/RedBall.cs
Assets/Mirror/Examples/Billiards/Ball/RedBall.cs.meta
Assets/Mirror/Examples/Billiards/Ball/White.mat
Assets/Mirror/Examples/Billiards/Ball/White.mat.meta
Assets/Mirror/Examples/Billiards/Ball/White.prefab
Assets/Mirror/Examples/Billiards/Ball/White.prefab.meta
Assets/Mirror/Examples/Billiards/Ball/WhiteBall.cs
Assets/Mirror/Examples/Billiards/Ball/WhiteBall.cs.meta
Assets/Mirror/Examples/Billiards/MirrorBilliards.unity
Assets/Mirror/Examples/Billiards/MirrorBilliards.unity.meta
Assets/Mirror/Examples/Billiards/Player.prefab
Assets/Mirror/Examples/Billiards/Player.prefab.meta
Assets/Mirror/Examples/Billiards/Table.meta
Assets/Mirror/Examples/Billiards/Table/Billiard Table.prefab
Assets/Mirror/Examples/Billiards/Table/Billiard Table.prefab.meta
Assets/Mirror/Examples/Billiards/Table/BilliardTable Model.obj
Assets/Mirror/Examples/Billiards/Table/BilliardTable Model.obj.meta
Assets/Mirror/Examples/Billiards/Table/BilliardTable.mtl
Assets/Mirror/Examples/Billiards/Table/BilliardTable.mtl.meta
Assets/Mirror/Examples/Billiards/Table/Body.mat
Assets/Mirror/Examples/Billiards/Table/Body.mat.meta
Assets/Mirror/Examples/Billiards/Table/Edge.mat
Assets/Mirror/Examples/Billiards/Table/Edge.mat.meta
Assets/Mirror/Examples/Billiards/Table/Felt.mat
Assets/Mirror/Examples/Billiards/Table/Felt.mat.meta
Assets/Mirror/Examples/Billiards/Table/Holes.mat
Assets/Mirror/Examples/Billiards/Table/Holes.mat.meta
Assets/Mirror/Examples/Billiards/Table/Lamp.mat
Assets/Mirror/Examples/Billiards/Table/Lamp.mat.meta
Assets/Mirror/Examples/Billiards/Table/License.txt
Assets/Mirror/Examples/Billiards/Table/License.txt.meta
Assets/Mirror/Examples/Billiards/Table/Pockets.mat
Assets/Mirror/Examples/Billiards/Table/Pockets.mat.meta
Assets/Mirror/Examples/Billiards/_Readme.txt
Assets/Mirror/Examples/Billiards/_Readme.txt.meta
Assets/Mirror/Examples/BilliardsPredicted.meta
Assets/Mirror/Examples/BilliardsPredicted/Ball.meta
Assets/Mirror/Examples/BilliardsPredicted/Ball/Pockets.cs
Assets/Mirror/Examples/BilliardsPredicted/Ball/Pockets.cs.meta
Assets/Mirror/Examples/BilliardsPredicted/Ball/Red.mat
Assets/Mirror/Examples/BilliardsPredicted/Ball/Red.mat.meta
Assets/Mirror/Examples/BilliardsPredicted/Ball/RedBallPredicted.cs
Assets/Mirror/Examples/BilliardsPredicted/Ball/RedBallPredicted.cs.meta
Assets/Mirror/Examples/BilliardsPredicted/Ball/RedPredicted.prefab
Assets/Mirror/Examples/BilliardsPredicted/Ball/RedPredicted.prefab.meta
Assets/Mirror/Examples/BilliardsPredicted/Ball/White.mat
Assets/Mirror/Examples/BilliardsPredicted/Ball/White.mat.meta
Assets/Mirror/Examples/BilliardsPredicted/Ball/WhiteBallPredicted.cs
Assets/Mirror/Examples/BilliardsPredicted/Ball/WhiteBallPredicted.cs.meta
Assets/Mirror/Examples/BilliardsPredicted/Ball/WhitePredicted.prefab
Assets/Mirror/Examples/BilliardsPredicted/Ball/WhitePredicted.prefab.meta
Assets/Mirror/Examples/BilliardsPredicted/MirrorBilliardsPredicted.unity
Assets/Mirror/Examples/BilliardsPredicted/MirrorBilliardsPredicted.unity.meta
Assets/Mirror/Examples/BilliardsPredicted/Player.meta
Assets/Mirror/Examples/BilliardsPredicted/Player/PlayerPredicted.cs
Assets/Mirror/Examples/BilliardsPredicted/Player/PlayerPredicted.cs.meta
Assets/Mirror/Examples/BilliardsPredicted/Player/PlayerPredicted.prefab
Assets/Mirror/Examples/BilliardsPredicted/Player/PlayerPredicted.prefab.meta
Assets/Mirror/Examples/BilliardsPredicted/_Readme.txt
Assets/Mirror/Examples/BilliardsPredicted/_Readme.txt.meta
Assets/Mirror/Examples/CCU.meta
Assets/Mirror/Examples/CCU/CCUNetworkManager.cs
Assets/Mirror/Examples/CCU/CCUNetworkManager.cs.meta
Assets/Mirror/Examples/CCU/MirrorCCU.unity
Assets/Mirror/Examples/CCU/MirrorCCU.unity.meta
Assets/Mirror/Examples/CCU/Monster.cs
Assets/Mirror/Examples/CCU/Monster.cs.meta
Assets/Mirror/Examples/CCU/Monster.prefab
Assets/Mirror/Examples/CCU/Monster.prefab.meta
Assets/Mirror/Examples/CCU/Player.cs
Assets/Mirror/Examples/CCU/Player.cs.meta
Assets/Mirror/Examples/CCU/Player.prefab
Assets/Mirror/Examples/CCU/Player.prefab.meta
Assets/Mirror/Examples/CCU/Readme.txt
Assets/Mirror/Examples/CCU/Readme.txt.meta
Assets/Mirror/Examples/CCU/Red.mat
Assets/Mirror/Examples/CCU/Red.mat.meta
Assets/Mirror/Examples/CCU/White.mat
Assets/Mirror/Examples/CCU/White.mat.meta
Assets/Mirror/Examples/CharacterSelection.meta
Assets/Mirror/Examples/CharacterSelection/Materials.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialBlack.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialBlack.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialBrown.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialBrown.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialDesert.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialDesert.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialFloor.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialFloor.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialGold.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialGold.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialGreenDark.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialGreenDark.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialIcon1.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialIcon1.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialRed.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialRed.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialSilver.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialSilver.mat.meta
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialWhite.mat
Assets/Mirror/Examples/CharacterSelection/Materials/MaterialWhite.mat.meta
Assets/Mirror/Examples/CharacterSelection/MirrorCharacterSelection.unity
Assets/Mirror/Examples/CharacterSelection/MirrorCharacterSelection.unity.meta
Assets/Mirror/Examples/CharacterSelection/MirrorCharacterSelectionNoCharacter.unity
Assets/Mirror/Examples/CharacterSelection/MirrorCharacterSelectionNoCharacter.unity.meta
Assets/Mirror/Examples/CharacterSelection/MirrorCharacterSelectionPreScene.unity
Assets/Mirror/Examples/CharacterSelection/MirrorCharacterSelectionPreScene.unity.meta
Assets/Mirror/Examples/CharacterSelection/Prefabs.meta
Assets/Mirror/Examples/CharacterSelection/Prefabs/CharacterData.prefab
Assets/Mirror/Examples/CharacterSelection/Prefabs/CharacterData.prefab.meta
Assets/Mirror/Examples/CharacterSelection/Prefabs/CharacterSelection.prefab
Assets/Mirror/Examples/CharacterSelection/Prefabs/CharacterSelection.prefab.meta
Assets/Mirror/Examples/CharacterSelection/Prefabs/Characters.meta
Assets/Mirror/Examples/CharacterSelection/Prefabs/Characters/CharacterAssault.prefab
Assets/Mirror/Examples/CharacterSelection/Prefabs/Characters/CharacterAssault.prefab.meta
Assets/Mirror/Examples/CharacterSelection/Prefabs/Characters/CharacterHeavy.prefab
Assets/Mirror/Examples/CharacterSelection/Prefabs/Characters/CharacterHeavy.prefab.meta
Assets/Mirror/Examples/CharacterSelection/Prefabs/Characters/CharacterMedic.prefab
Assets/Mirror/Examples/CharacterSelection/Prefabs/Characters/CharacterMedic.prefab.meta
Assets/Mirror/Examples/CharacterSelection/Prefabs/PlayerEmpty.prefab
Assets/Mirror/Examples/CharacterSelection/Prefabs/PlayerEmpty.prefab.meta
Assets/Mirror/Examples/CharacterSelection/Scripts.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/CanvasReferencer.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/CanvasReferencer.cs.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/CharacterData.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/CharacterData.cs.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/CharacterSelection.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/CharacterSelection.cs.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/NetworkManagerCharacterSelection.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/NetworkManagerCharacterSelection.cs.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/PlayerEmpty.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/PlayerEmpty.cs.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/SceneCamera.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/SceneCamera.cs.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/SceneReferencer.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/SceneReferencer.cs.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/ScriptAnimations.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/ScriptAnimations.cs.meta
Assets/Mirror/Examples/CharacterSelection/Scripts/StaticVariables.cs
Assets/Mirror/Examples/CharacterSelection/Scripts/StaticVariables.cs.meta
Assets/Mirror/Examples/CharacterSelection/Textures.meta
Assets/Mirror/Examples/CharacterSelection/Textures/IconRandomColour.png
Assets/Mirror/Examples/CharacterSelection/Textures/IconRandomColour.png.meta
Assets/Mirror/Examples/CharacterSelection/Textures/IconResetColour.png
Assets/Mirror/Examples/CharacterSelection/Textures/IconResetColour.png.meta
Assets/Mirror/Examples/CharacterSelection/Textures/IconStickPerson.png
Assets/Mirror/Examples/CharacterSelection/Textures/IconStickPerson.png.meta
Assets/Mirror/Examples/CharacterSelection/Textures/dirtMoon.jpg
Assets/Mirror/Examples/CharacterSelection/Textures/dirtMoon.jpg.meta
Assets/Mirror/Examples/CharacterSelection/_ReadMe.txt
Assets/Mirror/Examples/CharacterSelection/_ReadMe.txt.meta
Assets/Mirror/Examples/Chat.meta
Assets/Mirror/Examples/Chat/Prefabs.meta
Assets/Mirror/Examples/Chat/Prefabs/Player.prefab
Assets/Mirror/Examples/Chat/Prefabs/Player.prefab.meta
Assets/Mirror/Examples/Chat/Scenes.meta
Assets/Mirror/Examples/Chat/Scenes/MirrorChat.unity
Assets/Mirror/Examples/Chat/Scenes/MirrorChat.unity.meta
Assets/Mirror/Examples/Chat/Scripts.meta
Assets/Mirror/Examples/Chat/Scripts/ChatAuthenticator.cs
Assets/Mirror/Examples/Chat/Scripts/ChatAuthenticator.cs.meta
Assets/Mirror/Examples/Chat/Scripts/ChatNetworkManager.cs
Assets/Mirror/Examples/Chat/Scripts/ChatNetworkManager.cs.meta
Assets/Mirror/Examples/Chat/Scripts/ChatUI.cs
Assets/Mirror/Examples/Chat/Scripts/ChatUI.cs.meta
Assets/Mirror/Examples/Chat/Scripts/LoginUI.cs
Assets/Mirror/Examples/Chat/Scripts/LoginUI.cs.meta
Assets/Mirror/Examples/Chat/Scripts/Player.cs
Assets/Mirror/Examples/Chat/Scripts/Player.cs.meta
Assets/Mirror/Examples/CouchCoop.meta
Assets/Mirror/Examples/CouchCoop/Materials.meta
Assets/Mirror/Examples/CouchCoop/Materials/MaterialColliders.mat
Assets/Mirror/Examples/CouchCoop/Materials/MaterialColliders.mat.meta
Assets/Mirror/Examples/CouchCoop/Materials/MaterialGround.mat
Assets/Mirror/Examples/CouchCoop/Materials/MaterialGround.mat.meta
Assets/Mirror/Examples/CouchCoop/Materials/MaterialPlatform1.mat
Assets/Mirror/Examples/CouchCoop/Materials/MaterialPlatform1.mat.meta
Assets/Mirror/Examples/CouchCoop/Materials/MaterialPlatform2.mat
Assets/Mirror/Examples/CouchCoop/Materials/MaterialPlatform2.mat.meta
Assets/Mirror/Examples/CouchCoop/Materials/MaterialPlayer.mat
Assets/Mirror/Examples/CouchCoop/Materials/MaterialPlayer.mat.meta
Assets/Mirror/Examples/CouchCoop/MirrorCouchCoop.unity
Assets/Mirror/Examples/CouchCoop/MirrorCouchCoop.unity.meta
Assets/Mirror/Examples/CouchCoop/Prefabs.meta
Assets/Mirror/Examples/CouchCoop/Prefabs/CouchPlayer.prefab
Assets/Mirror/Examples/CouchCoop/Prefabs/CouchPlayer.prefab.meta
Assets/Mirror/Examples/CouchCoop/Prefabs/CouchPlayerManager.prefab
Assets/Mirror/Examples/CouchCoop/Prefabs/CouchPlayerManager.prefab.meta
Assets/Mirror/Examples/CouchCoop/Scripts.meta
Assets/Mirror/Examples/CouchCoop/Scripts/CameraViewForAll.cs
Assets/Mirror/Examples/CouchCoop/Scripts/CameraViewForAll.cs.meta
Assets/Mirror/Examples/CouchCoop/Scripts/CanvasScript.cs
Assets/Mirror/Examples/CouchCoop/Scripts/CanvasScript.cs.meta
Assets/Mirror/Examples/CouchCoop/Scripts/CouchPlayer.cs
Assets/Mirror/Examples/CouchCoop/Scripts/CouchPlayer.cs.meta
Assets/Mirror/Examples/CouchCoop/Scripts/CouchPlayerManager.cs
Assets/Mirror/Examples/CouchCoop/Scripts/CouchPlayerManager.cs.meta
Assets/Mirror/Examples/CouchCoop/Scripts/MovingPlatform.cs
Assets/Mirror/Examples/CouchCoop/Scripts/MovingPlatform.cs.meta
Assets/Mirror/Examples/CouchCoop/Scripts/PlatformMovement.cs
Assets/Mirror/Examples/CouchCoop/Scripts/PlatformMovement.cs.meta
Assets/Mirror/Examples/CouchCoop/_ReadMe.txt
Assets/Mirror/Examples/CouchCoop/_ReadMe.txt.meta
Assets/Mirror/Examples/Discovery.meta
Assets/Mirror/Examples/Discovery/Prefabs.meta
Assets/Mirror/Examples/Discovery/Prefabs/Player.prefab
Assets/Mirror/Examples/Discovery/Prefabs/Player.prefab.meta
Assets/Mirror/Examples/Discovery/Scenes.meta
Assets/Mirror/Examples/Discovery/Scenes/MirrorDiscovery.unity
Assets/Mirror/Examples/Discovery/Scenes/MirrorDiscovery.unity.meta
Assets/Mirror/Examples/EdgegapLobby.meta
Assets/Mirror/Examples/EdgegapLobby/EdgegapLobbyTanks.meta
Assets/Mirror/Examples/EdgegapLobby/EdgegapLobbyTanks.unity
Assets/Mirror/Examples/EdgegapLobby/EdgegapLobbyTanks.unity.meta
Assets/Mirror/Examples/EdgegapLobby/EdgegapLobbyTanks/NavMesh.asset
Assets/Mirror/Examples/EdgegapLobby/EdgegapLobbyTanks/NavMesh.asset.meta
Assets/Mirror/Examples/EdgegapLobby/Prefabs.meta
Assets/Mirror/Examples/EdgegapLobby/Prefabs/LobbyUI.prefab
Assets/Mirror/Examples/EdgegapLobby/Prefabs/LobbyUI.prefab.meta
Assets/Mirror/Examples/EdgegapLobby/Prefabs/LobbyUIEntry.prefab
Assets/Mirror/Examples/EdgegapLobby/Prefabs/LobbyUIEntry.prefab.meta
Assets/Mirror/Examples/EdgegapLobby/Scripts.meta
Assets/Mirror/Examples/EdgegapLobby/Scripts/UILobbyCreate.cs
Assets/Mirror/Examples/EdgegapLobby/Scripts/UILobbyCreate.cs.meta
Assets/Mirror/Examples/EdgegapLobby/Scripts/UILobbyEntry.cs
Assets/Mirror/Examples/EdgegapLobby/Scripts/UILobbyEntry.cs.meta
Assets/Mirror/Examples/EdgegapLobby/Scripts/UILobbyList.cs
Assets/Mirror/Examples/EdgegapLobby/Scripts/UILobbyList.cs.meta
Assets/Mirror/Examples/EdgegapLobby/Scripts/UILobbyStatus.cs
Assets/Mirror/Examples/EdgegapLobby/Scripts/UILobbyStatus.cs.meta
Assets/Mirror/Examples/EdgegapLobby/_ReadMe.txt
Assets/Mirror/Examples/EdgegapLobby/_ReadMe.txt.meta
Assets/Mirror/Examples/HexSpatialHash.meta
Assets/Mirror/Examples/HexSpatialHash/Hex2DSpatialHash.unity
Assets/Mirror/Examples/HexSpatialHash/Hex2DSpatialHash.unity.meta
Assets/Mirror/Examples/HexSpatialHash/Hex3DSpatialHash.unity
Assets/Mirror/Examples/HexSpatialHash/Hex3DSpatialHash.unity.meta
Assets/Mirror/Examples/HexSpatialHash/Mateirals.meta
Assets/Mirror/Examples/HexSpatialHash/Mateirals/RandomColor.mat
Assets/Mirror/Examples/HexSpatialHash/Mateirals/RandomColor.mat.meta
Assets/Mirror/Examples/HexSpatialHash/Prefabs.meta
Assets/Mirror/Examples/HexSpatialHash/Prefabs/Hex2DPlayer.prefab
Assets/Mirror/Examples/HexSpatialHash/Prefabs/Hex2DPlayer.prefab.meta
Assets/Mirror/Examples/HexSpatialHash/Prefabs/Hex3DPlayer.prefab
Assets/Mirror/Examples/HexSpatialHash/Prefabs/Hex3DPlayer.prefab.meta
Assets/Mirror/Examples/HexSpatialHash/Prefabs/SpawnPrefab.prefab
Assets/Mirror/Examples/HexSpatialHash/Prefabs/SpawnPrefab.prefab.meta
Assets/Mirror/Examples/HexSpatialHash/Scripts.meta
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex2DNetworkManager.cs
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex2DNetworkManager.cs.meta
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex2DPlayer.cs
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex2DPlayer.cs.meta
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex2DPlayerCamera.cs
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex2DPlayerCamera.cs.meta
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex3DNetworkManager.cs
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex3DNetworkManager.cs.meta
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex3DPlayer.cs
Assets/Mirror/Examples/HexSpatialHash/Scripts/Hex3DPlayer.cs.meta
Assets/Mirror/Examples/LagCompensation.meta
Assets/Mirror/Examples/LagCompensation/Capture2D.cs
Assets/Mirror/Examples/LagCompensation/Capture2D.cs.meta
Assets/Mirror/Examples/LagCompensation/ClientCube.cs
Assets/Mirror/Examples/LagCompensation/ClientCube.cs.meta
Assets/Mirror/Examples/LagCompensation/ClientMaterial.mat
Assets/Mirror/Examples/LagCompensation/ClientMaterial.mat.meta
Assets/Mirror/Examples/LagCompensation/MirrorLagCompensation.unity
Assets/Mirror/Examples/LagCompensation/MirrorLagCompensation.unity.meta
Assets/Mirror/Examples/LagCompensation/ServerCube.cs
Assets/Mirror/Examples/LagCompensation/ServerCube.cs.meta
Assets/Mirror/Examples/LagCompensation/ServerMaterial.mat
Assets/Mirror/Examples/LagCompensation/ServerMaterial.mat.meta
Assets/Mirror/Examples/LagCompensation/Snapshot3D.cs
Assets/Mirror/Examples/LagCompensation/Snapshot3D.cs.meta
Assets/Mirror/Examples/LagCompensation/_DISABLE VSYNC_
Assets/Mirror/Examples/LagCompensation/_DISABLE VSYNC_.meta
Assets/Mirror/Examples/LagCompensation/_README.txt
Assets/Mirror/Examples/LagCompensation/_README.txt.meta
Assets/Mirror/Examples/Mirror.Examples.asmdef
Assets/Mirror/Examples/Mirror.Examples.asmdef.meta
Assets/Mirror/Examples/MultipleAdditiveScenes.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Physics.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Physics/Icosphere.physicMaterial
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Physics/Icosphere.physicMaterial.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Physics/Player.physicMaterial
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Physics/Player.physicMaterial.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Physics/RoomBounce.physicMaterial
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Physics/RoomBounce.physicMaterial.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Render.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Render/PlayArea.mat
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Render/PlayArea.mat.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Render/Player.mat
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Render/Player.mat.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Render/Prize.mat
Assets/Mirror/Examples/MultipleAdditiveScenes/Materials/Render/Prize.mat.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Models.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Models/Icosphere.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Models/Icosphere/Icosphere.obj
Assets/Mirror/Examples/MultipleAdditiveScenes/Models/Icosphere/Icosphere.obj.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Models/Icosphere/Materials.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Models/Icosphere/Materials/Icosphere.mat
Assets/Mirror/Examples/MultipleAdditiveScenes/Models/Icosphere/Materials/Icosphere.mat.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs/Icosphere.prefab
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs/Icosphere.prefab.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs/PlayerReliable.prefab
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs/PlayerReliable.prefab.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs/PlayerUnreliable.prefab
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs/PlayerUnreliable.prefab.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs/Reward.prefab
Assets/Mirror/Examples/MultipleAdditiveScenes/Prefabs/Reward.prefab.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/README.md
Assets/Mirror/Examples/MultipleAdditiveScenes/README.md.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesGame.unity
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesGame.unity.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesMain.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesMain.unity
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesMain.unity.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesMain/LightingData.asset
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesMain/LightingData.asset.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesMain/ReflectionProbe-0.exr
Assets/Mirror/Examples/MultipleAdditiveScenes/Scenes/MirrorMultipleAdditiveScenesMain/ReflectionProbe-0.exr.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/MultiSceneNetManager.cs
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/MultiSceneNetManager.cs.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/PhysicsCollision.cs
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/PhysicsCollision.cs.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/PlayerScore.cs
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/PlayerScore.cs.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/Reward.cs
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/Reward.cs.meta
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/Spawner.cs
Assets/Mirror/Examples/MultipleAdditiveScenes/Scripts/Spawner.cs.meta
Assets/Mirror/Examples/MultipleMatches.meta
Assets/Mirror/Examples/MultipleMatches/Prefabs.meta
Assets/Mirror/Examples/MultipleMatches/Prefabs/CellGUI.prefab
Assets/Mirror/Examples/MultipleMatches/Prefabs/CellGUI.prefab.meta
Assets/Mirror/Examples/MultipleMatches/Prefabs/MatchController.prefab
Assets/Mirror/Examples/MultipleMatches/Prefabs/MatchController.prefab.meta
Assets/Mirror/Examples/MultipleMatches/Prefabs/MatchGUI.prefab
Assets/Mirror/Examples/MultipleMatches/Prefabs/MatchGUI.prefab.meta
Assets/Mirror/Examples/MultipleMatches/Prefabs/MatchPlayer.prefab
Assets/Mirror/Examples/MultipleMatches/Prefabs/MatchPlayer.prefab.meta
Assets/Mirror/Examples/MultipleMatches/Prefabs/PlayerGUI.prefab
Assets/Mirror/Examples/MultipleMatches/Prefabs/PlayerGUI.prefab.meta
Assets/Mirror/Examples/MultipleMatches/README.md
Assets/Mirror/Examples/MultipleMatches/README.md.meta
Assets/Mirror/Examples/MultipleMatches/Scenes.meta
Assets/Mirror/Examples/MultipleMatches/Scenes/MirrorMultipleMatches.unity
Assets/Mirror/Examples/MultipleMatches/Scenes/MirrorMultipleMatches.unity.meta
Assets/Mirror/Examples/MultipleMatches/Scripts.meta
Assets/Mirror/Examples/MultipleMatches/Scripts/CanvasController.cs
Assets/Mirror/Examples/MultipleMatches/Scripts/CanvasController.cs.meta
Assets/Mirror/Examples/MultipleMatches/Scripts/CellGUI.cs
Assets/Mirror/Examples/MultipleMatches/Scripts/CellGUI.cs.meta
Assets/Mirror/Examples/MultipleMatches/Scripts/MatchController.cs
Assets/Mirror/Examples/MultipleMatches/Scripts/MatchController.cs.meta
Assets/Mirror/Examples/MultipleMatches/Scripts/MatchGUI.cs
Assets/Mirror/Examples/MultipleMatches/Scripts/MatchGUI.cs.meta
Assets/Mirror/Examples/MultipleMatches/Scripts/MatchMessages.cs
Assets/Mirror/Examples/MultipleMatches/Scripts/MatchMessages.cs.meta
Assets/Mirror/Examples/MultipleMatches/Scripts/MatchNetworkManager.cs
Assets/Mirror/Examples/MultipleMatches/Scripts/MatchNetworkManager.cs.meta
Assets/Mirror/Examples/MultipleMatches/Scripts/PlayerGUI.cs
Assets/Mirror/Examples/MultipleMatches/Scripts/PlayerGUI.cs.meta
Assets/Mirror/Examples/MultipleMatches/Scripts/RoomGUI.cs
Assets/Mirror/Examples/MultipleMatches/Scripts/RoomGUI.cs.meta
Assets/Mirror/Examples/PickupsDropsChilds.meta
Assets/Mirror/Examples/PickupsDropsChilds/Materials.meta
Assets/Mirror/Examples/PickupsDropsChilds/Materials/Ball.mat
Assets/Mirror/Examples/PickupsDropsChilds/Materials/Ball.mat.meta
Assets/Mirror/Examples/PickupsDropsChilds/Materials/Bat.mat
Assets/Mirror/Examples/PickupsDropsChilds/Materials/Bat.mat.meta
Assets/Mirror/Examples/PickupsDropsChilds/Materials/Bouncy.physicMaterial
Assets/Mirror/Examples/PickupsDropsChilds/Materials/Bouncy.physicMaterial.meta
Assets/Mirror/Examples/PickupsDropsChilds/Materials/Box.mat
Assets/Mirror/Examples/PickupsDropsChilds/Materials/Box.mat.meta
Assets/Mirror/Examples/PickupsDropsChilds/PickupsDropsChilds.unity
Assets/Mirror/Examples/PickupsDropsChilds/PickupsDropsChilds.unity.meta
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs.meta
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Ball.prefab
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Ball.prefab.meta
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Bat.prefab
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Bat.prefab.meta
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Box.prefab
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Box.prefab.meta
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Custom Robot Kyle.prefab
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Custom Robot Kyle.prefab.meta
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Player.prefab
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/Player.prefab.meta
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/SceneObject.prefab
Assets/Mirror/Examples/PickupsDropsChilds/Prefabs/SceneObject.prefab.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Enumerations.cs
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Enumerations.cs.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces/EquippedBall.cs
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces/EquippedBall.cs.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces/EquippedBat.cs
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces/EquippedBat.cs.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces/EquippedBox.cs
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces/EquippedBox.cs.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces/IEquipped.cs
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/Interfaces/IEquipped.cs.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/PickupsDropsChilds.cs
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/PickupsDropsChilds.cs.meta
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/SceneObject.cs
Assets/Mirror/Examples/PickupsDropsChilds/Scripts/SceneObject.cs.meta
Assets/Mirror/Examples/PlayerTest.meta
Assets/Mirror/Examples/PlayerTest/PlayerHybrid.prefab
Assets/Mirror/Examples/PlayerTest/PlayerHybrid.prefab.meta
Assets/Mirror/Examples/PlayerTest/PlayerRBHybrid.prefab
Assets/Mirror/Examples/PlayerTest/PlayerRBHybrid.prefab.meta
Assets/Mirror/Examples/PlayerTest/PlayerRBReliable.prefab
Assets/Mirror/Examples/PlayerTest/PlayerRBReliable.prefab.meta
Assets/Mirror/Examples/PlayerTest/PlayerRBUnreliable.prefab
Assets/Mirror/Examples/PlayerTest/PlayerRBUnreliable.prefab.meta
Assets/Mirror/Examples/PlayerTest/PlayerReliable.prefab
Assets/Mirror/Examples/PlayerTest/PlayerReliable.prefab.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestNetMan.cs
Assets/Mirror/Examples/PlayerTest/PlayerTestNetMan.cs.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestScene.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestScene.unity
Assets/Mirror/Examples/PlayerTest/PlayerTestScene.unity.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/LightingData.asset
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/LightingData.asset.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/Lightmap-0_comp_dir.png
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/Lightmap-0_comp_dir.png.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/Lightmap-0_comp_light.exr
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/Lightmap-0_comp_light.exr.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/ReflectionProbe-0.exr
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/ReflectionProbe-0.exr.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/TerrainData2019.asset
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/TerrainData2019.asset.meta
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/TerrainLayer2019.terrainlayer
Assets/Mirror/Examples/PlayerTest/PlayerTestScene/TerrainLayer2019.terrainlayer.meta
Assets/Mirror/Examples/PlayerTest/PlayerUnreliable.prefab
Assets/Mirror/Examples/PlayerTest/PlayerUnreliable.prefab.meta
Assets/Mirror/Examples/PlayerTest/TankHybrid.prefab
Assets/Mirror/Examples/PlayerTest/TankHybrid.prefab.meta
Assets/Mirror/Examples/PlayerTest/TankReliable.prefab
Assets/Mirror/Examples/PlayerTest/TankReliable.prefab.meta
Assets/Mirror/Examples/PlayerTest/TankUnreliable.prefab
Assets/Mirror/Examples/PlayerTest/TankUnreliable.prefab.meta
Assets/Mirror/Examples/Pong.meta
Assets/Mirror/Examples/Pong/PhysicsMaterials.meta
Assets/Mirror/Examples/Pong/PhysicsMaterials/BallMaterial.physicsMaterial2D
Assets/Mirror/Examples/Pong/PhysicsMaterials/BallMaterial.physicsMaterial2D.meta
Assets/Mirror/Examples/Pong/Prefabs.meta
Assets/Mirror/Examples/Pong/Prefabs/Ball.prefab
Assets/Mirror/Examples/Pong/Prefabs/Ball.prefab.meta
Assets/Mirror/Examples/Pong/Prefabs/Racket.prefab
Assets/Mirror/Examples/Pong/Prefabs/Racket.prefab.meta
Assets/Mirror/Examples/Pong/Scenes.meta
Assets/Mirror/Examples/Pong/Scenes/MirrorPong.unity
Assets/Mirror/Examples/Pong/Scenes/MirrorPong.unity.meta
Assets/Mirror/Examples/Pong/Scripts.meta
Assets/Mirror/Examples/Pong/Scripts/Ball.cs
Assets/Mirror/Examples/Pong/Scripts/Ball.cs.meta
Assets/Mirror/Examples/Pong/Scripts/NetworkManagerPong.cs
Assets/Mirror/Examples/Pong/Scripts/NetworkManagerPong.cs.meta
Assets/Mirror/Examples/Pong/Scripts/Player.cs
Assets/Mirror/Examples/Pong/Scripts/Player.cs.meta
Assets/Mirror/Examples/Pong/Sprites.meta
Assets/Mirror/Examples/Pong/Sprites/Ball.png
Assets/Mirror/Examples/Pong/Sprites/Ball.png.meta
Assets/Mirror/Examples/Pong/Sprites/DottedLine.png
Assets/Mirror/Examples/Pong/Sprites/DottedLine.png.meta
Assets/Mirror/Examples/Pong/Sprites/Racket.png
Assets/Mirror/Examples/Pong/Sprites/Racket.png.meta
Assets/Mirror/Examples/Pong/Sprites/WallHorizontal.png
Assets/Mirror/Examples/Pong/Sprites/WallHorizontal.png.meta
Assets/Mirror/Examples/Pong/Sprites/WallVertical.png
Assets/Mirror/Examples/Pong/Sprites/WallVertical.png.meta
Assets/Mirror/Examples/RigidbodyBenchmark.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Materials.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Materials/Floor.mat
Assets/Mirror/Examples/RigidbodyBenchmark/Materials/Floor.mat.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Materials/Player.mat
Assets/Mirror/Examples/RigidbodyBenchmark/Materials/Player.mat.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Materials/Server.mat
Assets/Mirror/Examples/RigidbodyBenchmark/Materials/Server.mat.meta
Assets/Mirror/Examples/RigidbodyBenchmark/PhysicMaterials.meta
Assets/Mirror/Examples/RigidbodyBenchmark/PhysicMaterials/Ball.physicMaterial
Assets/Mirror/Examples/RigidbodyBenchmark/PhysicMaterials/Ball.physicMaterial.meta
Assets/Mirror/Examples/RigidbodyBenchmark/PhysicMaterials/Floor.physicMaterial
Assets/Mirror/Examples/RigidbodyBenchmark/PhysicMaterials/Floor.physicMaterial.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Prefabs.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Prefabs/Player Ball.prefab
Assets/Mirror/Examples/RigidbodyBenchmark/Prefabs/Player Ball.prefab.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Prefabs/Server Ball.prefab
Assets/Mirror/Examples/RigidbodyBenchmark/Prefabs/Server Ball.prefab.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Scenes.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Scenes/MirrorRigidbodyBenchmark.unity
Assets/Mirror/Examples/RigidbodyBenchmark/Scenes/MirrorRigidbodyBenchmark.unity.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Scripts.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Scripts/AddForce.cs
Assets/Mirror/Examples/RigidbodyBenchmark/Scripts/AddForce.cs.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Scripts/AutoForce.cs
Assets/Mirror/Examples/RigidbodyBenchmark/Scripts/AutoForce.cs.meta
Assets/Mirror/Examples/RigidbodyBenchmark/Scripts/RigidbodyBenchmarkNetworkManager.cs
Assets/Mirror/Examples/RigidbodyBenchmark/Scripts/RigidbodyBenchmarkNetworkManager.cs.meta
Assets/Mirror/Examples/RigidbodyPhysics.meta
Assets/Mirror/Examples/RigidbodyPhysics/Materials.meta
Assets/Mirror/Examples/RigidbodyPhysics/Materials/Floor.mat
Assets/Mirror/Examples/RigidbodyPhysics/Materials/Floor.mat.meta
Assets/Mirror/Examples/RigidbodyPhysics/Materials/Player.mat
Assets/Mirror/Examples/RigidbodyPhysics/Materials/Player.mat.meta
Assets/Mirror/Examples/RigidbodyPhysics/Materials/Server.mat
Assets/Mirror/Examples/RigidbodyPhysics/Materials/Server.mat.meta
Assets/Mirror/Examples/RigidbodyPhysics/PhysicMaterials.meta
Assets/Mirror/Examples/RigidbodyPhysics/PhysicMaterials/Ball.physicMaterial
Assets/Mirror/Examples/RigidbodyPhysics/PhysicMaterials/Ball.physicMaterial.meta
Assets/Mirror/Examples/RigidbodyPhysics/PhysicMaterials/Floor.physicMaterial
Assets/Mirror/Examples/RigidbodyPhysics/PhysicMaterials/Floor.physicMaterial.meta
Assets/Mirror/Examples/RigidbodyPhysics/Prefabs.meta
Assets/Mirror/Examples/RigidbodyPhysics/Prefabs/Player Ball.prefab
Assets/Mirror/Examples/RigidbodyPhysics/Prefabs/Player Ball.prefab.meta
Assets/Mirror/Examples/RigidbodyPhysics/Scenes.meta
Assets/Mirror/Examples/RigidbodyPhysics/Scenes/MirrorBounceScene.unity
Assets/Mirror/Examples/RigidbodyPhysics/Scenes/MirrorBounceScene.unity.meta
Assets/Mirror/Examples/RigidbodyPhysics/Scripts.meta
Assets/Mirror/Examples/RigidbodyPhysics/Scripts/AddForce.cs
Assets/Mirror/Examples/RigidbodyPhysics/Scripts/AddForce.cs.meta
Assets/Mirror/Examples/Room.meta
Assets/Mirror/Examples/Room/Materials.meta
Assets/Mirror/Examples/Room/Materials/PlayArea.mat
Assets/Mirror/Examples/Room/Materials/PlayArea.mat.meta
Assets/Mirror/Examples/Room/Materials/Player.mat
Assets/Mirror/Examples/Room/Materials/Player.mat.meta
Assets/Mirror/Examples/Room/Materials/Prize.mat
Assets/Mirror/Examples/Room/Materials/Prize.mat.meta
Assets/Mirror/Examples/Room/Prefabs.meta
Assets/Mirror/Examples/Room/Prefabs/GamePlayerReliable.prefab
Assets/Mirror/Examples/Room/Prefabs/GamePlayerReliable.prefab.meta
Assets/Mirror/Examples/Room/Prefabs/GamePlayerUnreliable.prefab
Assets/Mirror/Examples/Room/Prefabs/GamePlayerUnreliable.prefab.meta
Assets/Mirror/Examples/Room/Prefabs/Reward.prefab
Assets/Mirror/Examples/Room/Prefabs/Reward.prefab.meta
Assets/Mirror/Examples/Room/Prefabs/RoomPlayer.prefab
Assets/Mirror/Examples/Room/Prefabs/RoomPlayer.prefab.meta
Assets/Mirror/Examples/Room/README.md
Assets/Mirror/Examples/Room/README.md.meta
Assets/Mirror/Examples/Room/Scenes.meta
Assets/Mirror/Examples/Room/Scenes/MirrorRoomGame.meta
Assets/Mirror/Examples/Room/Scenes/MirrorRoomGame.unity
Assets/Mirror/Examples/Room/Scenes/MirrorRoomGame.unity.meta
Assets/Mirror/Examples/Room/Scenes/MirrorRoomGame/LightingData.asset
Assets/Mirror/Examples/Room/Scenes/MirrorRoomGame/LightingData.asset.meta
Assets/Mirror/Examples/Room/Scenes/MirrorRoomGame/ReflectionProbe-0.exr
Assets/Mirror/Examples/Room/Scenes/MirrorRoomGame/ReflectionProbe-0.exr.meta
Assets/Mirror/Examples/Room/Scenes/MirrorRoomOffline.unity
Assets/Mirror/Examples/Room/Scenes/MirrorRoomOffline.unity.meta
Assets/Mirror/Examples/Room/Scenes/MirrorRoomOnline.unity
Assets/Mirror/Examples/Room/Scenes/MirrorRoomOnline.unity.meta
Assets/Mirror/Examples/Room/Scripts.meta
Assets/Mirror/Examples/Room/Scripts/NetworkRoomManagerExt.cs
Assets/Mirror/Examples/Room/Scripts/NetworkRoomManagerExt.cs.meta
Assets/Mirror/Examples/Room/Scripts/NetworkRoomPlayerExt.cs
Assets/Mirror/Examples/Room/Scripts/NetworkRoomPlayerExt.cs.meta
Assets/Mirror/Examples/Room/Scripts/PlayerScore.cs
Assets/Mirror/Examples/Room/Scripts/PlayerScore.cs.meta
Assets/Mirror/Examples/Room/Scripts/Reward.cs
Assets/Mirror/Examples/Room/Scripts/Reward.cs.meta
Assets/Mirror/Examples/Room/Scripts/Spawner.cs
Assets/Mirror/Examples/Room/Scripts/Spawner.cs.meta
Assets/Mirror/Examples/Snapshot Interpolation.meta
Assets/Mirror/Examples/Snapshot Interpolation/ClientCube.cs
Assets/Mirror/Examples/Snapshot Interpolation/ClientCube.cs.meta
Assets/Mirror/Examples/Snapshot Interpolation/ClientMaterial.mat
Assets/Mirror/Examples/Snapshot Interpolation/ClientMaterial.mat.meta
Assets/Mirror/Examples/Snapshot Interpolation/MirrorSnapshotInterpolation.unity
Assets/Mirror/Examples/Snapshot Interpolation/MirrorSnapshotInterpolation.unity.meta
Assets/Mirror/Examples/Snapshot Interpolation/README.txt
Assets/Mirror/Examples/Snapshot Interpolation/README.txt.meta
Assets/Mirror/Examples/Snapshot Interpolation/ServerCube.cs
Assets/Mirror/Examples/Snapshot Interpolation/ServerCube.cs.meta
Assets/Mirror/Examples/Snapshot Interpolation/ServerMaterial.mat
Assets/Mirror/Examples/Snapshot Interpolation/ServerMaterial.mat.meta
Assets/Mirror/Examples/Snapshot Interpolation/Snapshot3D.cs
Assets/Mirror/Examples/Snapshot Interpolation/Snapshot3D.cs.meta
Assets/Mirror/Examples/Snapshot Interpolation/_DISABLE VSYNC_
Assets/Mirror/Examples/Snapshot Interpolation/_DISABLE VSYNC_.meta
Assets/Mirror/Examples/StackedPrediction.meta
Assets/Mirror/Examples/StackedPrediction/CubeMaterial.mat
Assets/Mirror/Examples/StackedPrediction/CubeMaterial.mat.meta
Assets/Mirror/Examples/StackedPrediction/CubeMaterial.physicMaterial
Assets/Mirror/Examples/StackedPrediction/CubeMaterial.physicMaterial.meta
Assets/Mirror/Examples/StackedPrediction/GroundMaterial.mat
Assets/Mirror/Examples/StackedPrediction/GroundMaterial.mat.meta
Assets/Mirror/Examples/StackedPrediction/MirrorStackedPrediction.unity
Assets/Mirror/Examples/StackedPrediction/MirrorStackedPrediction.unity.meta
Assets/Mirror/Examples/StackedPrediction/NetworkManagerStackedPrediction.cs
Assets/Mirror/Examples/StackedPrediction/NetworkManagerStackedPrediction.cs.meta
Assets/Mirror/Examples/StackedPrediction/PlayerForce.cs
Assets/Mirror/Examples/StackedPrediction/PlayerForce.cs.meta
Assets/Mirror/Examples/StackedPrediction/PlayerSpectator.prefab
Assets/Mirror/Examples/StackedPrediction/PlayerSpectator.prefab.meta
Assets/Mirror/Examples/StackedPrediction/PredictedCube.prefab
Assets/Mirror/Examples/StackedPrediction/PredictedCube.prefab.meta
Assets/Mirror/Examples/StackedPrediction/_Readme.txt
Assets/Mirror/Examples/StackedPrediction/_Readme.txt.meta
Assets/Mirror/Examples/SyncDirection.meta
Assets/Mirror/Examples/SyncDirection/MirrorSyncDirection.unity
Assets/Mirror/Examples/SyncDirection/MirrorSyncDirection.unity.meta
Assets/Mirror/Examples/SyncDirection/Player.cs
Assets/Mirror/Examples/SyncDirection/Player.cs.meta
Assets/Mirror/Examples/SyncDirection/Player.prefab
Assets/Mirror/Examples/SyncDirection/Player.prefab.meta
Assets/Mirror/Examples/SyncDirection/White.mat
Assets/Mirror/Examples/SyncDirection/White.mat.meta
Assets/Mirror/Examples/TankTheftAuto.meta
Assets/Mirror/Examples/TankTheftAuto/Materials.meta
Assets/Mirror/Examples/TankTheftAuto/Materials/MaterialPlayer.mat
Assets/Mirror/Examples/TankTheftAuto/Materials/MaterialPlayer.mat.meta
Assets/Mirror/Examples/TankTheftAuto/Materials/MaterialTrigger.mat
Assets/Mirror/Examples/TankTheftAuto/Materials/MaterialTrigger.mat.meta
Assets/Mirror/Examples/TankTheftAuto/MirrorTankTheftAuto.meta
Assets/Mirror/Examples/TankTheftAuto/MirrorTankTheftAuto.unity
Assets/Mirror/Examples/TankTheftAuto/MirrorTankTheftAuto.unity.meta
Assets/Mirror/Examples/TankTheftAuto/MirrorTankTheftAuto/LightingData.asset
Assets/Mirror/Examples/TankTheftAuto/MirrorTankTheftAuto/LightingData.asset.meta
Assets/Mirror/Examples/TankTheftAuto/Prefabs.meta
Assets/Mirror/Examples/TankTheftAuto/Prefabs/PlayerReliable.prefab
Assets/Mirror/Examples/TankTheftAuto/Prefabs/PlayerReliable.prefab.meta
Assets/Mirror/Examples/TankTheftAuto/Prefabs/PlayerUnreliable.prefab
Assets/Mirror/Examples/TankTheftAuto/Prefabs/PlayerUnreliable.prefab.meta
Assets/Mirror/Examples/TankTheftAuto/Prefabs/TankReliable.prefab
Assets/Mirror/Examples/TankTheftAuto/Prefabs/TankReliable.prefab.meta
Assets/Mirror/Examples/TankTheftAuto/Prefabs/TankUnreliable.prefab
Assets/Mirror/Examples/TankTheftAuto/Prefabs/TankUnreliable.prefab.meta
Assets/Mirror/Examples/TankTheftAuto/Scripts.meta
Assets/Mirror/Examples/TankTheftAuto/Scripts/TankAuthority.cs
Assets/Mirror/Examples/TankTheftAuto/Scripts/TankAuthority.cs.meta
Assets/Mirror/Examples/TankTheftAuto/Scripts/TankTheftAutoNetMan.cs
Assets/Mirror/Examples/TankTheftAuto/Scripts/TankTheftAutoNetMan.cs.meta
Assets/Mirror/Examples/Tanks.meta
Assets/Mirror/Examples/Tanks/Prefabs.meta
Assets/Mirror/Examples/Tanks/Prefabs/Projectile.prefab
Assets/Mirror/Examples/Tanks/Prefabs/Projectile.prefab.meta
Assets/Mirror/Examples/Tanks/Prefabs/Tank.prefab
Assets/Mirror/Examples/Tanks/Prefabs/Tank.prefab.meta
Assets/Mirror/Examples/Tanks/Readme.txt
Assets/Mirror/Examples/Tanks/Readme.txt.meta
Assets/Mirror/Examples/Tanks/Scenes.meta
Assets/Mirror/Examples/Tanks/Scenes/MirrorTanks.meta
Assets/Mirror/Examples/Tanks/Scenes/MirrorTanks.unity
Assets/Mirror/Examples/Tanks/Scenes/MirrorTanks.unity.meta
Assets/Mirror/Examples/Tanks/Scenes/MirrorTanks/NavMesh.asset
Assets/Mirror/Examples/Tanks/Scenes/MirrorTanks/NavMesh.asset.meta
Assets/Mirror/Examples/Tanks/Scripts.meta
Assets/Mirror/Examples/Tanks/Scripts/Box.cs
Assets/Mirror/Examples/Tanks/Scripts/Box.cs.meta
Assets/Mirror/Examples/Tanks/Scripts/Projectile.cs
Assets/Mirror/Examples/Tanks/Scripts/Projectile.cs.meta
Assets/Mirror/Examples/Tanks/Scripts/Tank.cs
Assets/Mirror/Examples/Tanks/Scripts/Tank.cs.meta
Assets/Mirror/Examples/TopDownShooter.meta
Assets/Mirror/Examples/TopDownShooter/Materials.meta
Assets/Mirror/Examples/TopDownShooter/Materials/DeathSplatter.mat
Assets/Mirror/Examples/TopDownShooter/Materials/DeathSplatter.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/Enemy.mat
Assets/Mirror/Examples/TopDownShooter/Materials/Enemy.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/EnemyHand1.mat
Assets/Mirror/Examples/TopDownShooter/Materials/EnemyHand1.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/EnemyHand2.mat
Assets/Mirror/Examples/TopDownShooter/Materials/EnemyHand2.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/Flash.mat
Assets/Mirror/Examples/TopDownShooter/Materials/Flash.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/Floor.mat
Assets/Mirror/Examples/TopDownShooter/Materials/Floor.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/HitPoint.mat
Assets/Mirror/Examples/TopDownShooter/Materials/HitPoint.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/MaterialBlack.mat
Assets/Mirror/Examples/TopDownShooter/Materials/MaterialBlack.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/MaterialGrey.mat
Assets/Mirror/Examples/TopDownShooter/Materials/MaterialGrey.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/MaterialWalls.mat
Assets/Mirror/Examples/TopDownShooter/Materials/MaterialWalls.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/MaterialYellow.mat
Assets/Mirror/Examples/TopDownShooter/Materials/MaterialYellow.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/Player.mat
Assets/Mirror/Examples/TopDownShooter/Materials/Player.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/PlayerLF.mat
Assets/Mirror/Examples/TopDownShooter/Materials/PlayerLF.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/PlayerRF.mat
Assets/Mirror/Examples/TopDownShooter/Materials/PlayerRF.mat.meta
Assets/Mirror/Examples/TopDownShooter/Materials/RespawnPortal.mat
Assets/Mirror/Examples/TopDownShooter/Materials/RespawnPortal.mat.meta
Assets/Mirror/Examples/TopDownShooter/Prefabs.meta
Assets/Mirror/Examples/TopDownShooter/Prefabs/DeathSplatter.prefab
Assets/Mirror/Examples/TopDownShooter/Prefabs/DeathSplatter.prefab.meta
Assets/Mirror/Examples/TopDownShooter/Prefabs/EnemyPrefab.prefab
Assets/Mirror/Examples/TopDownShooter/Prefabs/EnemyPrefab.prefab.meta
Assets/Mirror/Examples/TopDownShooter/Prefabs/PlayerPrefab.prefab
Assets/Mirror/Examples/TopDownShooter/Prefabs/PlayerPrefab.prefab.meta
Assets/Mirror/Examples/TopDownShooter/Scenes.meta
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter.meta
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter.unity
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter.unity.meta
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter/LightingData.asset
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter/LightingData.asset.meta
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter/NavMesh.asset
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter/NavMesh.asset.meta
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter/ReflectionProbe-0.exr
Assets/Mirror/Examples/TopDownShooter/Scenes/MirrorTopDownShooter/ReflectionProbe-0.exr.meta
Assets/Mirror/Examples/TopDownShooter/Scripts.meta
Assets/Mirror/Examples/TopDownShooter/Scripts/CameraTopDown.cs
Assets/Mirror/Examples/TopDownShooter/Scripts/CameraTopDown.cs.meta
Assets/Mirror/Examples/TopDownShooter/Scripts/CanvasHUD.cs
Assets/Mirror/Examples/TopDownShooter/Scripts/CanvasHUD.cs.meta
Assets/Mirror/Examples/TopDownShooter/Scripts/CanvasTopDown.cs
Assets/Mirror/Examples/TopDownShooter/Scripts/CanvasTopDown.cs.meta
Assets/Mirror/Examples/TopDownShooter/Scripts/EnemyTopDown.cs
Assets/Mirror/Examples/TopDownShooter/Scripts/EnemyTopDown.cs.meta
Assets/Mirror/Examples/TopDownShooter/Scripts/NetworkTopDown.cs
Assets/Mirror/Examples/TopDownShooter/Scripts/NetworkTopDown.cs.meta
Assets/Mirror/Examples/TopDownShooter/Scripts/PlayerTopDown.cs
Assets/Mirror/Examples/TopDownShooter/Scripts/PlayerTopDown.cs.meta
Assets/Mirror/Examples/TopDownShooter/Scripts/RespawnPortal.cs
Assets/Mirror/Examples/TopDownShooter/Scripts/RespawnPortal.cs.meta
Assets/Mirror/Examples/TopDownShooter/Textures.meta
Assets/Mirror/Examples/TopDownShooter/Textures/CornerUI.png
Assets/Mirror/Examples/TopDownShooter/Textures/CornerUI.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/DeathSplatter.png
Assets/Mirror/Examples/TopDownShooter/Textures/DeathSplatter.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/Enemy.png
Assets/Mirror/Examples/TopDownShooter/Textures/Enemy.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/EnemyHand1.png
Assets/Mirror/Examples/TopDownShooter/Textures/EnemyHand1.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/EnemyHand2.png
Assets/Mirror/Examples/TopDownShooter/Textures/EnemyHand2.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/Flash.png
Assets/Mirror/Examples/TopDownShooter/Textures/Flash.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/Floor.jpg
Assets/Mirror/Examples/TopDownShooter/Textures/Floor.jpg.meta
Assets/Mirror/Examples/TopDownShooter/Textures/HitPoint.png
Assets/Mirror/Examples/TopDownShooter/Textures/HitPoint.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/Player.png
Assets/Mirror/Examples/TopDownShooter/Textures/Player.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/PlayerFootLeft.png
Assets/Mirror/Examples/TopDownShooter/Textures/PlayerFootLeft.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/PlayerFootRight.png
Assets/Mirror/Examples/TopDownShooter/Textures/PlayerFootRight.png.meta
Assets/Mirror/Examples/TopDownShooter/Textures/RespawnPortal.png
Assets/Mirror/Examples/TopDownShooter/Textures/RespawnPortal.png.meta
Assets/Mirror/Examples/VR.meta
Assets/Mirror/Examples/VR/Readme.txt
Assets/Mirror/Examples/VR/Readme.txt.meta
Assets/Mirror/Examples/_Common.meta
Assets/Mirror/Examples/_Common/Controllers.meta
Assets/Mirror/Examples/_Common/Controllers/ControllerUIBase.cs
Assets/Mirror/Examples/_Common/Controllers/ControllerUIBase.cs.meta
Assets/Mirror/Examples/_Common/Controllers/FlyerController.meta
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerBase.cs
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerBase.cs.meta
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerReliable.cs
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerReliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerUI.cs
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerUI.cs.meta
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerUI.prefab
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerUI.prefab.meta
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerUnreliable.cs
Assets/Mirror/Examples/_Common/Controllers/FlyerController/FlyerControllerUnreliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerController.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerBase.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerBase.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerHybrid.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerHybrid.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerReliable.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerReliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerUI.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerUI.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerUI.prefab
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerUI.prefab.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerUnreliable.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerController/PlayerControllerUnreliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBBase.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBBase.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBHybrid.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBHybrid.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBReliable.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBReliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBUI.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBUI.cs.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBUI.prefab
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBUI.prefab.meta
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBUnreliable.cs
Assets/Mirror/Examples/_Common/Controllers/PlayerControllerRB/PlayerControllerRBUnreliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerBase.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerBase.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerHybrid.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerHybrid.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerReliable.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerReliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerUI.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerUI.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerUI.prefab
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerUI.prefab.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerUnreliable.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankControllerUnreliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankHealth.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankHealth.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankTurretBase.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankTurretBase.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankTurretHybrid.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankTurretHybrid.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankTurretReliable.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankTurretReliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TankTurretUnreliable.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TankTurretUnreliable.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TurretUI.cs
Assets/Mirror/Examples/_Common/Controllers/TankController/TurretUI.cs.meta
Assets/Mirror/Examples/_Common/Controllers/TankController/TurretUI.prefab
Assets/Mirror/Examples/_Common/Controllers/TankController/TurretUI.prefab.meta
Assets/Mirror/Examples/_Common/KenneyAssets.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_kenney-fonts.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_kenney-fonts/Fonts.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_kenney-fonts/Fonts/Kenney Mini.ttf
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_kenney-fonts/Fonts/Kenney Mini.ttf.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_kenney-fonts/License.txt
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_kenney-fonts/License.txt.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_rpg-audio.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_rpg-audio/Audio.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_rpg-audio/Audio/footstep06.ogg
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_rpg-audio/Audio/footstep06.ogg.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_rpg-audio/Audio/footstep09.ogg
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_rpg-audio/Audio/footstep09.ogg.meta
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_rpg-audio/License.txt
Assets/Mirror/Examples/_Common/KenneyAssets/kenney_rpg-audio/License.txt.meta
Assets/Mirror/Examples/_Common/OpenGameArt.meta
Assets/Mirror/Examples/_Common/OpenGameArt/License.txt
Assets/Mirror/Examples/_Common/OpenGameArt/License.txt.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/05._damage_grunt_male.mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/05._damage_grunt_male.mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/8bit_gunloop_explosion.mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/8bit_gunloop_explosion.mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/Light Switch Click On Sfx.mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/Light Switch Click On Sfx.mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/The Good Fight (just intro).mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/The Good Fight (just intro).mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/The Good Fight (no intro).mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/The Good Fight (no intro).mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/hjm-tesla_sound_shot.mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/hjm-tesla_sound_shot.mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/impactsplat03.mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/impactsplat03.mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/mutantdie.mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/mutantdie.mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/vgmenuhighlight.mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/vgmenuhighlight.mp3.meta
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/wolf_monster.mp3
Assets/Mirror/Examples/_Common/OpenGameArt/Sounds/wolf_monster.mp3.meta
Assets/Mirror/Examples/_Common/Projectiles.meta
Assets/Mirror/Examples/_Common/Projectiles/TankProjectile.meta
Assets/Mirror/Examples/_Common/Projectiles/TankProjectile/TankProjectile.cs
Assets/Mirror/Examples/_Common/Projectiles/TankProjectile/TankProjectile.cs.meta
Assets/Mirror/Examples/_Common/Projectiles/TankProjectile/TankProjectile.mat
Assets/Mirror/Examples/_Common/Projectiles/TankProjectile/TankProjectile.mat.meta
Assets/Mirror/Examples/_Common/Projectiles/TankProjectile/TankProjectile.prefab
Assets/Mirror/Examples/_Common/Projectiles/TankProjectile/TankProjectile.prefab.meta
Assets/Mirror/Examples/_Common/RobotKyle.meta
Assets/Mirror/Examples/_Common/RobotKyle/Materials.meta
Assets/Mirror/Examples/_Common/RobotKyle/Materials/Robot_Color.mat
Assets/Mirror/Examples/_Common/RobotKyle/Materials/Robot_Color.mat.meta
Assets/Mirror/Examples/_Common/RobotKyle/Models.meta
Assets/Mirror/Examples/_Common/RobotKyle/Models/Robot Kyle.fbx
Assets/Mirror/Examples/_Common/RobotKyle/Models/Robot Kyle.fbx.meta
Assets/Mirror/Examples/_Common/RobotKyle/Robot Kyle.prefab
Assets/Mirror/Examples/_Common/RobotKyle/Robot Kyle.prefab.meta
Assets/Mirror/Examples/_Common/RobotKyle/Textures.meta
Assets/Mirror/Examples/_Common/RobotKyle/Textures/Robot_Color.jpeg
Assets/Mirror/Examples/_Common/RobotKyle/Textures/Robot_Color.jpeg.meta
Assets/Mirror/Examples/_Common/RobotKyle/Textures/Robot_Normal.jpeg
Assets/Mirror/Examples/_Common/RobotKyle/Textures/Robot_Normal.jpeg.meta
Assets/Mirror/Examples/_Common/Scripts.meta
Assets/Mirror/Examples/_Common/Scripts/CanvasNetworkManagerHUD.meta
Assets/Mirror/Examples/_Common/Scripts/CanvasNetworkManagerHUD/CanvasNetworkManagerHUD.cs
Assets/Mirror/Examples/_Common/Scripts/CanvasNetworkManagerHUD/CanvasNetworkManagerHUD.cs.meta
Assets/Mirror/Examples/_Common/Scripts/CanvasNetworkManagerHUD/CanvasNetworkManagerHUD.prefab
Assets/Mirror/Examples/_Common/Scripts/CanvasNetworkManagerHUD/CanvasNetworkManagerHUD.prefab.meta
Assets/Mirror/Examples/_Common/Scripts/FPS.cs
Assets/Mirror/Examples/_Common/Scripts/FPS.cs.meta
Assets/Mirror/Examples/_Common/Scripts/FaceCamera.cs
Assets/Mirror/Examples/_Common/Scripts/FaceCamera.cs.meta
Assets/Mirror/Examples/_Common/Scripts/PerlinNoise.cs
Assets/Mirror/Examples/_Common/Scripts/PerlinNoise.cs.meta
Assets/Mirror/Examples/_Common/Scripts/PhysicsSimulator.meta
Assets/Mirror/Examples/_Common/Scripts/PhysicsSimulator/PhysicsSimulator.cs
Assets/Mirror/Examples/_Common/Scripts/PhysicsSimulator/PhysicsSimulator.cs.meta
Assets/Mirror/Examples/_Common/Scripts/PhysicsSimulator/PhysicsSimulator.prefab
Assets/Mirror/Examples/_Common/Scripts/PhysicsSimulator/PhysicsSimulator.prefab.meta
Assets/Mirror/Examples/_Common/Scripts/PlayerCamera.cs
Assets/Mirror/Examples/_Common/Scripts/PlayerCamera.cs.meta
Assets/Mirror/Examples/_Common/Scripts/RandomColor.cs
Assets/Mirror/Examples/_Common/Scripts/RandomColor.cs.meta
Assets/Mirror/Examples/_Common/Scripts/Respawn.cs
Assets/Mirror/Examples/_Common/Scripts/Respawn.cs.meta
Assets/Mirror/Examples/_Common/TankModel.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/BaseColor.png
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/BaseColor.png.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Controller.controller
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Controller.controller.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Emissive.png
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Emissive.png.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Metallic.png
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Metallic.png.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Normal.png
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Normal.png.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Recon_Tank - License.txt
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/Recon_Tank - License.txt.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/TankMaterial.mat
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/TankMaterial.mat.meta
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/reconTank.fbx
Assets/Mirror/Examples/_Common/TankModel/(Public Domain) Recon_Tank/reconTank.fbx.meta
Assets/Mirror/Examples/_Common/TankModel/BasePrefab.prefab
Assets/Mirror/Examples/_Common/TankModel/BasePrefab.prefab.meta
Assets/Mirror/Examples/_Common/Textures.meta
Assets/Mirror/Examples/_Common/Textures/(Public Domain) Dirt Hand Painted Texture.meta
Assets/Mirror/Examples/_Common/Textures/(Public Domain) Dirt Hand Painted Texture/Dirt Hand Painted Texture - License.txt
Assets/Mirror/Examples/_Common/Textures/(Public Domain) Dirt Hand Painted Texture/Dirt Hand Painted Texture - License.txt.meta
Assets/Mirror/Examples/_Common/Textures/(Public Domain) Dirt Hand Painted Texture/Dirt.mat
Assets/Mirror/Examples/_Common/Textures/(Public Domain) Dirt Hand Painted Texture/Dirt.mat.meta
Assets/Mirror/Examples/_Common/Textures/(Public Domain) Dirt Hand Painted Texture/dirt.png
Assets/Mirror/Examples/_Common/Textures/(Public Domain) Dirt Hand Painted Texture/dirt.png.meta
Assets/Mirror/Examples/_Common/Textures/Wall01.jpg
Assets/Mirror/Examples/_Common/Textures/Wall01.jpg.meta
Assets/Mirror/Examples/_Common/Textures/Wall01_n.jpg
Assets/Mirror/Examples/_Common/Textures/Wall01_n.jpg.meta
Assets/Mirror/Hosting.meta
Assets/Mirror/Hosting/Edgegap.meta
Assets/Mirror/Hosting/Edgegap/CHANGELOG.md
Assets/Mirror/Hosting/Edgegap/CHANGELOG.md.meta
Assets/Mirror/Hosting/Edgegap/Dependencies.meta
Assets/Mirror/Hosting/Edgegap/Dependencies/HttpEncoder.cs
Assets/Mirror/Hosting/Edgegap/Dependencies/HttpEncoder.cs.meta
Assets/Mirror/Hosting/Edgegap/Dependencies/HttpUtility.cs
Assets/Mirror/Hosting/Edgegap/Dependencies/HttpUtility.cs.meta
Assets/Mirror/Hosting/Edgegap/Edgegap.asmdef
Assets/Mirror/Hosting/Edgegap/Edgegap.asmdef.meta
Assets/Mirror/Hosting/Edgegap/Editor.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapApiBase.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapApiBase.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapAppApi.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapAppApi.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapDeploymentsApi.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapDeploymentsApi.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapIpApi.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapIpApi.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapWizardApi.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/EdgegapWizardApi.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/AppPortsData.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/AppPortsData.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/DeploymentPortsData.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/DeploymentPortsData.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/LocationData.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/LocationData.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/ProtocolType.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/ProtocolType.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests/CreateAppRequest.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests/CreateAppRequest.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests/CreateAppVersionRequest.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests/CreateAppVersionRequest.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests/CreateDeploymentRequest.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests/CreateDeploymentRequest.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests/UpdateAppVersionRequest.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Requests/UpdateAppVersionRequest.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/CreateDeploymentResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/CreateDeploymentResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/EdgegapErrorResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/EdgegapErrorResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/EdgegapHttpResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/EdgegapHttpResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetAppVersionsResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetAppVersionsResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetAppsResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetAppsResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetCreateAppResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetCreateAppResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetDeploymentResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetDeploymentResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetDeploymentStatusResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetDeploymentStatusResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetDeploymentsResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetDeploymentsResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetRegistryCredentialsResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetRegistryCredentialsResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetYourPublicIpResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/GetYourPublicIpResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/StopActiveDeploymentResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/StopActiveDeploymentResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/UpsertAppVersionResult.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/Results/UpsertAppVersionResult.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/SessionData.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/SessionData.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/VersionData.cs
Assets/Mirror/Hosting/Edgegap/Editor/Api/Models/VersionData.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/ButtonShaker.cs
Assets/Mirror/Hosting/Edgegap/Editor/ButtonShaker.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/CustomPopupContent.cs
Assets/Mirror/Hosting/Edgegap/Editor/CustomPopupContent.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Dockerfile
Assets/Mirror/Hosting/Edgegap/Editor/Dockerfile.meta
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapBuildUtils.cs
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapBuildUtils.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapServerData.uss
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapServerData.uss.meta
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapServerDataManager.cs
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapServerDataManager.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapWindow.uss
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapWindow.uss.meta
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapWindow.uxml
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapWindow.uxml.meta
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapWindowMetadata.cs
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapWindowMetadata.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapWindowV2.cs
Assets/Mirror/Hosting/Edgegap/Editor/EdgegapWindowV2.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/BaronNeue SDF.asset
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/BaronNeue SDF.asset.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Spartan-Regular SDF.asset
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Spartan-Regular SDF.asset.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Spartan-SemiBold SDF.asset
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Spartan-SemiBold SDF.asset.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/BaronNeue.otf
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/BaronNeue.otf.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/Spartan.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/Spartan/Spartan-Regular.ttf
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/Spartan/Spartan-Regular.ttf.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/Spartan/Spartan-SemiBold.ttf
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/Spartan/Spartan-SemiBold.ttf.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/UbuntuMono-R.ttf
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/Src/UbuntuMono-R.ttf.meta
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/UbuntuMono-R SDF.asset
Assets/Mirror/Hosting/Edgegap/Editor/Fonts/UbuntuMono-R SDF.asset.meta
Assets/Mirror/Hosting/Edgegap/Editor/GithubRelease.cs
Assets/Mirror/Hosting/Edgegap/Editor/GithubRelease.cs.meta
Assets/Mirror/Hosting/Edgegap/Editor/Images.meta
Assets/Mirror/Hosting/Edgegap/Editor/Images/clipboard-128.png
Assets/Mirror/Hosting/Edgegap/Editor/Images/clipboard-128.png.meta
Assets/Mirror/Hosting/Edgegap/Editor/Images/discord-brands-solid-64px.png
Assets/Mirror/Hosting/Edgegap/Editor/Images/discord-brands-solid-64px.png.meta
Assets/Mirror/Hosting/Edgegap/Editor/Images/discord-brands-solid.svg
Assets/Mirror/Hosting/Edgegap/Editor/Images/discord-brands-solid.svg.meta
Assets/Mirror/Hosting/Edgegap/Editor/Images/logo_transparent_400_alpha25.png
Assets/Mirror/Hosting/Edgegap/Editor/Images/logo_transparent_400_alpha25.png.meta
Assets/Mirror/Hosting/Edgegap/Editor/PackageJSON.cs
Assets/Mirror/Hosting/Edgegap/Editor/PackageJSON.cs.meta
Assets/Mirror/Hosting/Edgegap/Enums.meta
Assets/Mirror/Hosting/Edgegap/Enums/ApiEnvironment.cs
Assets/Mirror/Hosting/Edgegap/Enums/ApiEnvironment.cs.meta
Assets/Mirror/Hosting/Edgegap/Enums/ServerStatus.cs
Assets/Mirror/Hosting/Edgegap/Enums/ServerStatus.cs.meta
Assets/Mirror/Hosting/Edgegap/Enums/ToolState.cs
Assets/Mirror/Hosting/Edgegap/Enums/ToolState.cs.meta
Assets/Mirror/Hosting/Edgegap/LICENSE.md
Assets/Mirror/Hosting/Edgegap/LICENSE.md.meta
Assets/Mirror/Hosting/Edgegap/Models.meta
Assets/Mirror/Hosting/Edgegap/Models/AppVersionUpdatePatchData.cs
Assets/Mirror/Hosting/Edgegap/Models/AppVersionUpdatePatchData.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/DeployPostData.cs
Assets/Mirror/Hosting/Edgegap/Models/DeployPostData.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/ApiModelContainercrashdata.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/ApiModelContainercrashdata.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/ApiModelContainerlogs.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/ApiModelContainerlogs.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppCreation.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppCreation.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersion.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersion.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionCreateSessionConfig.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionCreateSessionConfig.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionEnv.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionEnv.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionPort.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionPort.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionProbe.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionProbe.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionUpdate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionUpdate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionUpdateSessionConfig.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionUpdateSessionConfig.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionWhitelistEntry.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionWhitelistEntry.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionWhitelistEntryPayload.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionWhitelistEntryPayload.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionWhitelistEntrySuccess.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionWhitelistEntrySuccess.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionWhitelistResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersionWhitelistResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersions.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/AppVersions.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Application.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Application.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/ApplicationPatch.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/ApplicationPatch.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/ApplicationPost.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/ApplicationPost.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Applications.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Applications.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/BaseModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/BaseModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/BulkSessionDelete.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/BulkSessionDelete.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/BulkSessionPost.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/BulkSessionPost.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/ComponentCredentials.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/ComponentCredentials.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/ContainerLogStorageModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/ContainerLogStorageModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/CustomBulkSessionModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/CustomBulkSessionModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/CustomBulkSessionsModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/CustomBulkSessionsModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/CustomSessionDeleteModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/CustomSessionDeleteModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/CustomSessionModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/CustomSessionModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Delete.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Delete.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/DeployEnvModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/DeployEnvModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/DeployModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/DeployModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Deployment.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Deployment.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/DeploymentLocation.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/DeploymentLocation.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/DeploymentSessionContext.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/DeploymentSessionContext.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Deployments.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Deployments.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Error.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Error.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/GeoIpListModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/GeoIpListModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Location.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Location.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/LocationModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/LocationModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Locations.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Locations.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentCreate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentCreate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentEnvListResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentEnvListResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentEnvsCreate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentEnvsCreate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentEnvsResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentEnvsResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentEnvsUpdate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentEnvsUpdate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentListResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentListResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentUpdate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerComponentUpdate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerCreate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerCreate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerListResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerListResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerManagedReleaseCreate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerManagedReleaseCreate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerManagedReleaseResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerManagedReleaseResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerManagedReleaseUpdate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerManagedReleaseUpdate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseConfigCreate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseConfigCreate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseConfigResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseConfigResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseConfigUpdate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseConfigUpdate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseCreate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseCreate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseCreateBase.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseCreateBase.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseResponseBase.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseResponseBase.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseUpdate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseUpdate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseUpdateBase.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerReleaseUpdateBase.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerUpdate.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MatchmakerUpdate.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MetricsModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MetricsModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/MetricsResponse.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/MetricsResponse.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Monitor.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Monitor.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/NetworkMetricsModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/NetworkMetricsModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Pagination.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Pagination.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Paginator.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Paginator.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/PatchSessionModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/PatchSessionModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/PortMapping.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/PortMapping.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Request.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Request.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SelectorEnvModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SelectorEnvModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SelectorModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SelectorModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionContext.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionContext.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionDelete.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionDelete.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionGet.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionGet.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionRequest.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionRequest.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionUser.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionUser.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionUserContext.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/SessionUserContext.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Sessions.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Sessions.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/StaticSites.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/StaticSites.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/StaticSitesList.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/StaticSitesList.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/Status.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/Status.cs.meta
Assets/Mirror/Hosting/Edgegap/Models/SDK/TotalMetricsModel.cs
Assets/Mirror/Hosting/Edgegap/Models/SDK/TotalMetricsModel.cs.meta
Assets/Mirror/Hosting/Edgegap/Newtonsoft_Package_Patch.cs
Assets/Mirror/Hosting/Edgegap/Newtonsoft_Package_Patch.cs.meta
Assets/Mirror/Hosting/Edgegap/README.md
Assets/Mirror/Hosting/Edgegap/README.md.meta
Assets/Mirror/Hosting/Edgegap/_MIRROR_README.md
Assets/Mirror/Hosting/Edgegap/_MIRROR_README.md.meta
Assets/Mirror/Hosting/Edgegap/package.json
Assets/Mirror/Hosting/Edgegap/package.json.meta
Assets/Mirror/Hosting/Readme.txt
Assets/Mirror/Hosting/Readme.txt.meta
Assets/Mirror/LICENSE
Assets/Mirror/LICENSE.meta
Assets/Mirror/Plugins.meta
Assets/Mirror/Plugins/Mono.Cecil.meta
Assets/Mirror/Plugins/Mono.Cecil/License.txt
Assets/Mirror/Plugins/Mono.Cecil/License.txt.meta
Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.Mdb.dll
Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.Mdb.dll.meta
Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.Pdb.dll
Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.Pdb.dll.meta
Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.Rocks.dll
Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.Rocks.dll.meta
Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.dll
Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.dll.meta
Assets/Mirror/Presets.meta
Assets/Mirror/Presets/Network Transform (Reliable).meta
Assets/Mirror/Presets/Network Transform (Reliable)/ClientAuth-Balanced.preset
Assets/Mirror/Presets/Network Transform (Reliable)/ClientAuth-Balanced.preset.meta
Assets/Mirror/Presets/Network Transform (Reliable)/ClientAuth-Casual.preset
Assets/Mirror/Presets/Network Transform (Reliable)/ClientAuth-Casual.preset.meta
Assets/Mirror/Presets/Network Transform (Reliable)/ClientAuth-Responsive.preset
Assets/Mirror/Presets/Network Transform (Reliable)/ClientAuth-Responsive.preset.meta
Assets/Mirror/Presets/Network Transform (Reliable)/ServerAuth-Balanced.preset
Assets/Mirror/Presets/Network Transform (Reliable)/ServerAuth-Balanced.preset.meta
Assets/Mirror/Presets/Network Transform (Unreliable).meta
Assets/Mirror/Presets/Network Transform (Unreliable)/ClientAuth-Balanced.preset
Assets/Mirror/Presets/Network Transform (Unreliable)/ClientAuth-Balanced.preset.meta
Assets/Mirror/Presets/Network Transform (Unreliable)/ClientAuth-Casual.preset
Assets/Mirror/Presets/Network Transform (Unreliable)/ClientAuth-Casual.preset.meta
Assets/Mirror/Presets/Network Transform (Unreliable)/ClientAuth-Responsive.preset
Assets/Mirror/Presets/Network Transform (Unreliable)/ClientAuth-Responsive.preset.meta
Assets/Mirror/Presets/Network Transform (Unreliable)/ServerAuth-Balanced.preset
Assets/Mirror/Presets/Network Transform (Unreliable)/ServerAuth-Balanced.preset.meta
Assets/Mirror/Readme.txt
Assets/Mirror/Readme.txt.meta
Assets/Mirror/Transports.meta
Assets/Mirror/Transports/Edgegap.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/EdgegapLobbyKcpTransport.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/EdgegapLobbyKcpTransport.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/LobbyApi.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/LobbyApi.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/LobbyServiceCreateDialogue.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/LobbyServiceCreateDialogue.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/LobbyTransportInspector.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/LobbyTransportInspector.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/ListLobbiesResponse.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/ListLobbiesResponse.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/Lobby.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/Lobby.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyBrief.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyBrief.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyCreateRequest.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyCreateRequest.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyIdRequest.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyIdRequest.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyJoinOrLeaveRequest.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyJoinOrLeaveRequest.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyUpdateRequest.cs
Assets/Mirror/Transports/Edgegap/EdgegapLobby/Models/LobbyUpdateRequest.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapRelay.meta
Assets/Mirror/Transports/Edgegap/EdgegapRelay/EdgegapKcpClient.cs
Assets/Mirror/Transports/Edgegap/EdgegapRelay/EdgegapKcpClient.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapRelay/EdgegapKcpServer.cs
Assets/Mirror/Transports/Edgegap/EdgegapRelay/EdgegapKcpServer.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapRelay/EdgegapKcpTransport.cs
Assets/Mirror/Transports/Edgegap/EdgegapRelay/EdgegapKcpTransport.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapRelay/Protocol.cs
Assets/Mirror/Transports/Edgegap/EdgegapRelay/Protocol.cs.meta
Assets/Mirror/Transports/Edgegap/EdgegapRelay/README.md
Assets/Mirror/Transports/Edgegap/EdgegapRelay/README.md.meta
Assets/Mirror/Transports/Edgegap/EdgegapRelay/RelayCredentialsFromArgs.cs
Assets/Mirror/Transports/Edgegap/EdgegapRelay/RelayCredentialsFromArgs.cs.meta
Assets/Mirror/Transports/Edgegap/edgegap.png
Assets/Mirror/Transports/Edgegap/edgegap.png.meta
Assets/Mirror/Transports/Encryption.meta
Assets/Mirror/Transports/Encryption/Editor.meta
Assets/Mirror/Transports/Encryption/Editor/EncryptionTransportEditor.asmdef
Assets/Mirror/Transports/Encryption/Editor/EncryptionTransportEditor.asmdef.meta
Assets/Mirror/Transports/Encryption/Editor/EncryptionTransportInspector.cs
Assets/Mirror/Transports/Encryption/Editor/EncryptionTransportInspector.cs.meta
Assets/Mirror/Transports/Encryption/EncryptedConnection.cs
Assets/Mirror/Transports/Encryption/EncryptedConnection.cs.meta
Assets/Mirror/Transports/Encryption/EncryptionCredentials.cs
Assets/Mirror/Transports/Encryption/EncryptionCredentials.cs.meta
Assets/Mirror/Transports/Encryption/EncryptionTransport.cs
Assets/Mirror/Transports/Encryption/EncryptionTransport.cs.meta
Assets/Mirror/Transports/Encryption/Plugins.meta
Assets/Mirror/Transports/Encryption/Plugins/BouncyCastle.meta
Assets/Mirror/Transports/Encryption/Plugins/BouncyCastle/LICENSE.md
Assets/Mirror/Transports/Encryption/Plugins/BouncyCastle/LICENSE.md.meta
Assets/Mirror/Transports/Encryption/Plugins/BouncyCastle/Mirror.BouncyCastle.Cryptography.dll
Assets/Mirror/Transports/Encryption/Plugins/BouncyCastle/Mirror.BouncyCastle.Cryptography.dll.meta
Assets/Mirror/Transports/Encryption/PubKeyInfo.cs
Assets/Mirror/Transports/Encryption/PubKeyInfo.cs.meta
Assets/Mirror/Transports/Encryption/ThreadedEncryptionKcpTransport.cs
Assets/Mirror/Transports/Encryption/ThreadedEncryptionKcpTransport.cs.meta
Assets/Mirror/Transports/KCP.meta
Assets/Mirror/Transports/KCP/KcpTransport.cs
Assets/Mirror/Transports/KCP/KcpTransport.cs.meta
Assets/Mirror/Transports/KCP/ThreadedKcpTransport.cs
Assets/Mirror/Transports/KCP/ThreadedKcpTransport.cs.meta
Assets/Mirror/Transports/KCP/kcp2k.meta
Assets/Mirror/Transports/KCP/kcp2k/KCP.asmdef
Assets/Mirror/Transports/KCP/kcp2k/KCP.asmdef.meta
Assets/Mirror/Transports/KCP/kcp2k/LICENSE.txt
Assets/Mirror/Transports/KCP/kcp2k/LICENSE.txt.meta
Assets/Mirror/Transports/KCP/kcp2k/VERSION.txt
Assets/Mirror/Transports/KCP/kcp2k/VERSION.txt.meta
Assets/Mirror/Transports/KCP/kcp2k/empty.meta
Assets/Mirror/Transports/KCP/kcp2k/empty/KcpServerNonAlloc.cs
Assets/Mirror/Transports/KCP/kcp2k/empty/KcpServerNonAlloc.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/Common.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/Common.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/ErrorCode.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/ErrorCode.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/Extensions.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/Extensions.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpChannel.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpChannel.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpClient.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpClient.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpConfig.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpConfig.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpHeader.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpHeader.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpPeer.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpPeer.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpServer.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpServer.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpServerConnection.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpServerConnection.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpState.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/KcpState.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/highlevel/Log.cs
Assets/Mirror/Transports/KCP/kcp2k/highlevel/Log.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/kcp.meta
Assets/Mirror/Transports/KCP/kcp2k/kcp/AckItem.cs
Assets/Mirror/Transports/KCP/kcp2k/kcp/AckItem.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/kcp/AssemblyInfo.cs
Assets/Mirror/Transports/KCP/kcp2k/kcp/AssemblyInfo.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/kcp/Kcp.cs
Assets/Mirror/Transports/KCP/kcp2k/kcp/Kcp.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/kcp/Pool.cs
Assets/Mirror/Transports/KCP/kcp2k/kcp/Pool.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/kcp/Segment.cs
Assets/Mirror/Transports/KCP/kcp2k/kcp/Segment.cs.meta
Assets/Mirror/Transports/KCP/kcp2k/kcp/Utils.cs
Assets/Mirror/Transports/KCP/kcp2k/kcp/Utils.cs.meta
Assets/Mirror/Transports/Latency.meta
Assets/Mirror/Transports/Latency/LatencySimulation.cs
Assets/Mirror/Transports/Latency/LatencySimulation.cs.meta
Assets/Mirror/Transports/Middleware.meta
Assets/Mirror/Transports/Middleware/MiddlewareTransport.cs
Assets/Mirror/Transports/Middleware/MiddlewareTransport.cs.meta
Assets/Mirror/Transports/Mirror.Transports.asmdef
Assets/Mirror/Transports/Mirror.Transports.asmdef.meta
Assets/Mirror/Transports/Multiplex.meta
Assets/Mirror/Transports/Multiplex/MultiplexTransport.cs
Assets/Mirror/Transports/Multiplex/MultiplexTransport.cs.meta
Assets/Mirror/Transports/SimpleWeb.meta
Assets/Mirror/Transports/SimpleWeb/.cert.example.Json
Assets/Mirror/Transports/SimpleWeb/.cert.example.Json.meta
Assets/Mirror/Transports/SimpleWeb/Editor.meta
Assets/Mirror/Transports/SimpleWeb/Editor/ClientWebsocketSettingsDrawer.cs
Assets/Mirror/Transports/SimpleWeb/Editor/ClientWebsocketSettingsDrawer.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/AssemblyInfo.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/AssemblyInfo.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/CHANGELOG.md
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/CHANGELOG.md.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/ClientWebsocketSettings.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/ClientWebsocketSettings.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/SimpleWebClient.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/SimpleWebClient.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/StandAlone.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/StandAlone/ClientHandshake.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/StandAlone/ClientHandshake.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/StandAlone/ClientSslHelper.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/StandAlone/ClientSslHelper.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/StandAlone/WebSocketClientStandAlone.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/StandAlone/WebSocketClientStandAlone.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/Webgl.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/Webgl/SimpleWebJSLib.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/Webgl/SimpleWebJSLib.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/Webgl/WebSocketClientWebGl.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/Webgl/WebSocketClientWebGl.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/Webgl/plugin.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/Webgl/plugin/SimpleWeb.jslib
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Client/Webgl/plugin/SimpleWeb.jslib.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/BufferPool.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/BufferPool.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Connection.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Connection.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Constants.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Constants.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/EventType.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/EventType.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Log.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Log.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Message.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Message.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/MessageProcessor.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/MessageProcessor.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/ReadHelper.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/ReadHelper.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/ReceiveLoop.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/ReceiveLoop.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Request.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Request.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/SendLoop.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/SendLoop.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/TcpConfig.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/TcpConfig.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Utils.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Common/Utils.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/LICENSE
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/LICENSE.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/README.txt
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/README.txt.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server/ServerHandshake.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server/ServerHandshake.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server/ServerSslHelper.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server/ServerSslHelper.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server/SimpleWebServer.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server/SimpleWebServer.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server/WebSocketServer.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/Server/WebSocketServer.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/SimpleWebTransport.asmdef
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/SimpleWebTransport.asmdef.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/SslConfigLoader.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWeb/SslConfigLoader.cs.meta
Assets/Mirror/Transports/SimpleWeb/SimpleWebTransport.cs
Assets/Mirror/Transports/SimpleWeb/SimpleWebTransport.cs.meta
Assets/Mirror/Transports/Telepathy.meta
Assets/Mirror/Transports/Telepathy/Telepathy.meta
Assets/Mirror/Transports/Telepathy/Telepathy/Client.cs
Assets/Mirror/Transports/Telepathy/Telepathy/Client.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/Common.cs
Assets/Mirror/Transports/Telepathy/Telepathy/Common.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/ConnectionState.cs
Assets/Mirror/Transports/Telepathy/Telepathy/ConnectionState.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/EventType.cs
Assets/Mirror/Transports/Telepathy/Telepathy/EventType.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/LICENSE
Assets/Mirror/Transports/Telepathy/Telepathy/LICENSE.meta
Assets/Mirror/Transports/Telepathy/Telepathy/Log.cs
Assets/Mirror/Transports/Telepathy/Telepathy/Log.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/MagnificentReceivePipe.cs
Assets/Mirror/Transports/Telepathy/Telepathy/MagnificentReceivePipe.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/MagnificentSendPipe.cs
Assets/Mirror/Transports/Telepathy/Telepathy/MagnificentSendPipe.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/NetworkStreamExtensions.cs
Assets/Mirror/Transports/Telepathy/Telepathy/NetworkStreamExtensions.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/Pool.cs
Assets/Mirror/Transports/Telepathy/Telepathy/Pool.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/Server.cs
Assets/Mirror/Transports/Telepathy/Telepathy/Server.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/Telepathy.asmdef
Assets/Mirror/Transports/Telepathy/Telepathy/Telepathy.asmdef.meta
Assets/Mirror/Transports/Telepathy/Telepathy/ThreadFunctions.cs
Assets/Mirror/Transports/Telepathy/Telepathy/ThreadFunctions.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/Utils.cs
Assets/Mirror/Transports/Telepathy/Telepathy/Utils.cs.meta
Assets/Mirror/Transports/Telepathy/Telepathy/VERSION
Assets/Mirror/Transports/Telepathy/Telepathy/VERSION.meta
Assets/Mirror/Transports/Telepathy/TelepathyTransport.cs
Assets/Mirror/Transports/Telepathy/TelepathyTransport.cs.meta
Assets/Mirror/Transports/Threaded.meta
Assets/Mirror/Transports/Threaded/ThreadedTransport.cs
Assets/Mirror/Transports/Threaded/ThreadedTransport.cs.meta
Assets/Mirror/version.txt
Assets/Mirror/version.txt.meta
Assets/PolygonStarter/Materials.meta
Assets/PolygonStarter/Materials/Misc.meta
Assets/PolygonStarter/Materials/Misc/PolygonStarter_Clouds_Mat.mat
Assets/PolygonStarter/Materials/Misc/PolygonStarter_Clouds_Mat.mat.meta
Assets/PolygonStarter/Materials/Misc/PolygonStarter_Mat_01_Glass.mat
Assets/PolygonStarter/Materials/Misc/PolygonStarter_Mat_01_Glass.mat.meta
Assets/PolygonStarter/Materials/Misc/PolygonStarter_SimpleSky_01.mat
Assets/PolygonStarter/Materials/Misc/PolygonStarter_SimpleSky_01.mat.meta
Assets/PolygonStarter/Materials/Plane.meta
Assets/PolygonStarter/Materials/Plane/PolygonStarter_Mat_Plane_01.mat
Assets/PolygonStarter/Materials/Plane/PolygonStarter_Mat_Plane_01.mat.meta
Assets/PolygonStarter/Materials/Plane/PolygonStarter_Mat_Plane_02.mat
Assets/PolygonStarter/Materials/Plane/PolygonStarter_Mat_Plane_02.mat.meta
Assets/PolygonStarter/Materials/Plane/PolygonStarter_Mat_Plane_03.mat
Assets/PolygonStarter/Materials/Plane/PolygonStarter_Mat_Plane_03.mat.meta
Assets/PolygonStarter/Materials/Plane/PolygonStarter_Mat_Plane_04.mat
Assets/PolygonStarter/Materials/Plane/PolygonStarter_Mat_Plane_04.mat.meta
Assets/PolygonStarter/Materials/PolygonStarter_Mat_01.mat
Assets/PolygonStarter/Materials/PolygonStarter_Mat_01.mat.meta
Assets/PolygonStarter/Materials/PolygonStarter_Mat_02.mat
Assets/PolygonStarter/Materials/PolygonStarter_Mat_02.mat.meta
Assets/PolygonStarter/Materials/PolygonStarter_Mat_03.mat
Assets/PolygonStarter/Materials/PolygonStarter_Mat_03.mat.meta
Assets/PolygonStarter/Materials/PolygonStarter_Mat_04.mat
Assets/PolygonStarter/Materials/PolygonStarter_Mat_04.mat.meta
Assets/PolygonStarter/Models.meta
Assets/PolygonStarter/Models/Characters.fbx
Assets/PolygonStarter/Models/Characters.fbx.meta
Assets/PolygonStarter/Models/Collision.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_Block_1x1_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_Block_1x1_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_Column_2x3_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_Column_2x3_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_DoorFrame_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_DoorFrame_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_Floor_1x1_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_Floor_1x1_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_Ramp_25_1x1_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_Ramp_25_1x1_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_Stairs_1x1_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_Stairs_1x1_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_Stairs_1x3_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_Stairs_1x3_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_WallDoor_2x3_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_WallDoor_2x3_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Buildings_WallWindow_2x3_01.fbx
Assets/PolygonStarter/Models/Collision/SM_Buildings_WallWindow_2x3_01.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_PolygonApocalypse_Bld_House_01_Collision.fbx
Assets/PolygonStarter/Models/Collision/SM_PolygonApocalypse_Bld_House_01_Collision.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_PolygonCity_Veh_Car_Small_01_Collision.fbx
Assets/PolygonStarter/Models/Collision/SM_PolygonCity_Veh_Car_Small_01_Collision.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Primitive_Cone_02.fbx
Assets/PolygonStarter/Models/Collision/SM_Primitive_Cone_02.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Primitive_Cylander_02.fbx
Assets/PolygonStarter/Models/Collision/SM_Primitive_Cylander_02.fbx.meta
Assets/PolygonStarter/Models/Collision/SM_Primitive_Sphere_02.fbx
Assets/PolygonStarter/Models/Collision/SM_Primitive_Sphere_02.fbx.meta
Assets/PolygonStarter/Models/SM_Bean_Cop_01.fbx
Assets/PolygonStarter/Models/SM_Bean_Cop_01.fbx.meta
Assets/PolygonStarter/Models/SM_Bean_Cowboy_01.fbx
Assets/PolygonStarter/Models/SM_Bean_Cowboy_01.fbx.meta
Assets/PolygonStarter/Models/SM_Bean_Female_01.fbx
Assets/PolygonStarter/Models/SM_Bean_Female_01.fbx.meta
Assets/PolygonStarter/Models/SM_Bean_Town_Female_01.fbx
Assets/PolygonStarter/Models/SM_Bean_Town_Female_01.fbx.meta
Assets/PolygonStarter/Models/SM_Bld_Door_01.fbx
Assets/PolygonStarter/Models/SM_Bld_Door_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_CloudRing_01.fbx
Assets/PolygonStarter/Models/SM_Generic_CloudRing_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Ground_01.fbx
Assets/PolygonStarter/Models/SM_Generic_Ground_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Ground_02.fbx
Assets/PolygonStarter/Models/SM_Generic_Ground_02.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Ground_03.fbx
Assets/PolygonStarter/Models/SM_Generic_Ground_03.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Ground_04.fbx
Assets/PolygonStarter/Models/SM_Generic_Ground_04.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Ground_Flat_01.fbx
Assets/PolygonStarter/Models/SM_Generic_Ground_Flat_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Mountains_Grass_02.fbx
Assets/PolygonStarter/Models/SM_Generic_Mountains_Grass_02.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Mountains_Soft_01.fbx
Assets/PolygonStarter/Models/SM_Generic_Mountains_Soft_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_01.fbx
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_02.fbx
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_02.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_03.fbx
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_03.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_04.fbx
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_04.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_05.fbx
Assets/PolygonStarter/Models/SM_Generic_Small_Rocks_05.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_TreeDead_01.fbx
Assets/PolygonStarter/Models/SM_Generic_TreeDead_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_TreeStump_01.fbx
Assets/PolygonStarter/Models/SM_Generic_TreeStump_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Tree_01.fbx
Assets/PolygonStarter/Models/SM_Generic_Tree_01.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Tree_02.fbx
Assets/PolygonStarter/Models/SM_Generic_Tree_02.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Tree_03.fbx
Assets/PolygonStarter/Models/SM_Generic_Tree_03.fbx.meta
Assets/PolygonStarter/Models/SM_Generic_Tree_04.fbx
Assets/PolygonStarter/Models/SM_Generic_Tree_04.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonApocalypse_Bld_House_01.fbx
Assets/PolygonStarter/Models/SM_PolygonApocalypse_Bld_House_01.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonCity_Veh_Car_Small_01.fbx
Assets/PolygonStarter/Models/SM_PolygonCity_Veh_Car_Small_01.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Block_1x1_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Block_1x1_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Column_2x3_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Column_2x3_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_DoorFrame_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_DoorFrame_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Floor_1x1_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Floor_1x1_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Floor_5x5_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Floor_5x5_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Ramp_25_1x1_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Ramp_25_1x1_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Ramp_45_1x1_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Ramp_45_1x1_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Stairs_1x1_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Stairs_1x1_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Stairs_1x3_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_Stairs_1x3_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_WallDoor_2x3_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_WallDoor_2x3_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_WallWindow_2x3_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Buildings_WallWindow_2x3_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Icon_Arrow_Small_01.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Icon_Arrow_Small_01.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Icon_Coin_01.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Icon_Coin_01.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Icon_Letter_Question_01.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Icon_Letter_Question_01.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Primitive_Cone_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Primitive_Cone_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Primitive_Cylander_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Primitive_Cylander_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Primitive_Sphere_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Primitive_Sphere_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Primitive_Tube_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Primitive_Tube_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Cone_01.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Cone_01.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Crate_03.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Crate_03.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Ladder_1x2_01P.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Ladder_1x2_01P.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Sword_01.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Sword_01.fbx.meta
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Target_03.fbx
Assets/PolygonStarter/Models/SM_PolygonPrototype_Prop_Target_03.fbx.meta
Assets/PolygonStarter/Models/SM_Prop_Plane_Ring_01.fbx
Assets/PolygonStarter/Models/SM_Prop_Plane_Ring_01.fbx.meta
Assets/PolygonStarter/Models/SM_SimpleSky_Dome_01.fbx
Assets/PolygonStarter/Models/SM_SimpleSky_Dome_01.fbx.meta
Assets/PolygonStarter/Models/SM_Veh_Plane_Stunt_01.fbx
Assets/PolygonStarter/Models/SM_Veh_Plane_Stunt_01.fbx.meta
Assets/PolygonStarter/Models/SM_Wep_Shield_04.fbx
Assets/PolygonStarter/Models/SM_Wep_Shield_04.fbx.meta
Assets/PolygonStarter/Models/SM_Wep_WaterPistol_01.fbx
Assets/PolygonStarter/Models/SM_Wep_WaterPistol_01.fbx.meta
Assets/PolygonStarter/Models/SM_Wep_Watergun_01.fbx
Assets/PolygonStarter/Models/SM_Wep_Watergun_01.fbx.meta
Assets/PolygonStarter/Models/SM_Wep_Watergun_02.fbx
Assets/PolygonStarter/Models/SM_Wep_Watergun_02.fbx.meta
Assets/PolygonStarter/Prefabs.meta
Assets/PolygonStarter/Prefabs/Characters.meta
Assets/PolygonStarter/Prefabs/Characters/SM_Bean_Cop_01.prefab
Assets/PolygonStarter/Prefabs/Characters/SM_Bean_Cop_01.prefab.meta
Assets/PolygonStarter/Prefabs/Characters/SM_Bean_Cowboy_01.prefab
Assets/PolygonStarter/Prefabs/Characters/SM_Bean_Cowboy_01.prefab.meta
Assets/PolygonStarter/Prefabs/Characters/SM_Bean_Female_01.prefab
Assets/PolygonStarter/Prefabs/Characters/SM_Bean_Female_01.prefab.meta
Assets/PolygonStarter/Prefabs/Characters/SM_Bean_Town_Female_01.prefab
Assets/PolygonStarter/Prefabs/Characters/SM_Bean_Town_Female_01.prefab.meta
Assets/PolygonStarter/Prefabs/Characters/SM_Character_Female_01.prefab
Assets/PolygonStarter/Prefabs/Characters/SM_Character_Female_01.prefab.meta
Assets/PolygonStarter/Prefabs/Characters/SM_Character_Male_01.prefab
Assets/PolygonStarter/Prefabs/Characters/SM_Character_Male_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Bld_Door_01.prefab
Assets/PolygonStarter/Prefabs/SM_Bld_Door_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_CloudRing_01.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_CloudRing_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_01.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_02.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_02.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_03.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_03.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_04.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_04.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_Flat_01.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Ground_Flat_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Mountains_Grass_02.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Mountains_Grass_02.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Mountains_Soft_01.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Mountains_Soft_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_01.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_02.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_02.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_03.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_03.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_04.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_04.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_05.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Small_Rocks_05.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_TreeDead_01.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_TreeDead_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_TreeStump_01.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_TreeStump_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Tree_01.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Tree_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Tree_02.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Tree_02.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Tree_03.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Tree_03.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Generic_Tree_04.prefab
Assets/PolygonStarter/Prefabs/SM_Generic_Tree_04.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonApocalypse_Bld_House_01.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonApocalypse_Bld_House_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonCity_Veh_Car_Small_01.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonCity_Veh_Car_Small_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Block_1x1_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Block_1x1_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Column_2x3_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Column_2x3_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_DoorFrame_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_DoorFrame_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Floor_1x1_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Floor_1x1_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Floor_5x5_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Floor_5x5_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Ramp_25_1x1_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Ramp_25_1x1_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Ramp_45_1x1_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Ramp_45_1x1_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Stairs_1x1_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Stairs_1x1_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Stairs_1x3_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_Stairs_1x3_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_WallDoor_2x3_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_WallDoor_2x3_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_WallWindow_2x3_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Buildings_WallWindow_2x3_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Icon_Arrow_Small_01.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Icon_Arrow_Small_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Icon_Coin_01.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Icon_Coin_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Icon_Letter_Question_01.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Icon_Letter_Question_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Primitive_Cone_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Primitive_Cone_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Primitive_Cylander_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Primitive_Cylander_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Primitive_Sphere_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Primitive_Sphere_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Primitive_Tube_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Primitive_Tube_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Cone_01.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Cone_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Crate_03.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Crate_03.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Ladder_1x2_01P.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Ladder_1x2_01P.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Sword_01.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Sword_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Target_03.prefab
Assets/PolygonStarter/Prefabs/SM_PolygonPrototype_Prop_Target_03.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Prop_Plane_Ring_01.prefab
Assets/PolygonStarter/Prefabs/SM_Prop_Plane_Ring_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_SimpleSky_Dome_01.prefab
Assets/PolygonStarter/Prefabs/SM_SimpleSky_Dome_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Veh_Plane_Stunt_01.prefab
Assets/PolygonStarter/Prefabs/SM_Veh_Plane_Stunt_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Wep_Shield_04.prefab
Assets/PolygonStarter/Prefabs/SM_Wep_Shield_04.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Wep_WaterPistol_01.prefab
Assets/PolygonStarter/Prefabs/SM_Wep_WaterPistol_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Wep_Watergun_01.prefab
Assets/PolygonStarter/Prefabs/SM_Wep_Watergun_01.prefab.meta
Assets/PolygonStarter/Prefabs/SM_Wep_Watergun_02.prefab
Assets/PolygonStarter/Prefabs/SM_Wep_Watergun_02.prefab.meta
Assets/PolygonStarter/Scenes.meta
Assets/PolygonStarter/Scenes/Demo.unity
Assets/PolygonStarter/Scenes/Demo.unity.meta
Assets/PolygonStarter/Scenes/DemoSettings.lighting
Assets/PolygonStarter/Scenes/DemoSettings.lighting.meta
Assets/PolygonStarter/Textures.meta
Assets/PolygonStarter/Textures/PolygonStarter_Texture_01.png
Assets/PolygonStarter/Textures/PolygonStarter_Texture_01.png.meta
Assets/PolygonStarter/Textures/PolygonStarter_Texture_02.png
Assets/PolygonStarter/Textures/PolygonStarter_Texture_02.png.meta
Assets/PolygonStarter/Textures/PolygonStarter_Texture_03.png
Assets/PolygonStarter/Textures/PolygonStarter_Texture_03.png.meta
Assets/PolygonStarter/Textures/PolygonStarter_Texture_04.png
Assets/PolygonStarter/Textures/PolygonStarter_Texture_04.png.meta
Assets/PolygonStarter/Textures/Polygon_Plane_Texture_01.png
Assets/PolygonStarter/Textures/Polygon_Plane_Texture_01.png.meta
Assets/PolygonStarter/Textures/Polygon_Plane_Texture_02.png
Assets/PolygonStarter/Textures/Polygon_Plane_Texture_02.png.meta
Assets/PolygonStarter/Textures/Polygon_Plane_Texture_03.png
Assets/PolygonStarter/Textures/Polygon_Plane_Texture_03.png.meta
Assets/PolygonStarter/Textures/Polygon_Plane_Texture_04.png
Assets/PolygonStarter/Textures/Polygon_Plane_Texture_04.png.meta
Assets/PolygonStarter/Textures/Simple_Sky_Texture_01.png
Assets/PolygonStarter/Textures/Simple_Sky_Texture_01.png.meta
Assets/ScriptTemplates.meta
Assets/ScriptTemplates/50-Mirror__Network Manager-NewNetworkManager.cs.txt
Assets/ScriptTemplates/51-Mirror__Network Manager With Actions-NewNetworkManagerWithActions.cs.txt
Assets/ScriptTemplates/52-Mirror__Network Authenticator-NewNetworkAuthenticator.cs.txt
Assets/ScriptTemplates/52-Mirror__Network Behaviour-NewNetworkBehaviour.cs.txt
Assets/ScriptTemplates/53-Mirror__Network Behaviour With Actions-NewNetworkBehaviourWithActions.cs.txt
Assets/ScriptTemplates/54-Mirror__Custom Interest Management-CustomInterestManagement.cs.txt
Assets/ScriptTemplates/54-Mirror__Network Room Manager-NewNetworkRoomManager.cs.txt
Assets/ScriptTemplates/55-Mirror__Network Room Player-NewNetworkRoomPlayer.cs.txt
Assets/ScriptTemplates/56-Mirror__Network Discovery-NewNetworkDiscovery.cs.txt
Assets/ScriptTemplates/57-Mirror__Network Transform-NewNetworkTransform.cs.txt
Assets/ScriptTemplates/Editor.meta
Assets/ScriptTemplates/Editor/MoveToAssetsFolder.cs
Assets/Settings/Build Profiles.meta
Assets/Settings/Build Profiles/SpaceColony-Dev.asset
Assets/Settings/Build Profiles/SpaceColony-Dev.asset.meta
Assets/Settings/PC_RPAsset.asset
Assets/Settings/UniversalRenderPipelineGlobalSettings.asset
Assets/Simple UI Elements.meta
Assets/Simple UI Elements/Raw and SpriteSheets.meta
Assets/Simple UI Elements/Raw and SpriteSheets/Black1x.png
Assets/Simple UI Elements/Raw and SpriteSheets/Black1x.png.meta
Assets/Simple UI Elements/Raw and SpriteSheets/Black2x.png
Assets/Simple UI Elements/Raw and SpriteSheets/Black2x.png.meta
Assets/Simple UI Elements/Raw and SpriteSheets/Extras.png
Assets/Simple UI Elements/Raw and SpriteSheets/Extras.png.meta
Assets/Simple UI Elements/Raw and SpriteSheets/UI assets.svg
Assets/Simple UI Elements/Raw and SpriteSheets/UI assets.svg.meta
Assets/Simple UI Elements/Raw and SpriteSheets/White1x.png
Assets/Simple UI Elements/Raw and SpriteSheets/White1x.png.meta
Assets/Simple UI Elements/Raw and SpriteSheets/White2x.png
Assets/Simple UI Elements/Raw and SpriteSheets/White2x.png.meta
Assets/Simple UI Elements/Scenes.meta
Assets/Simple UI Elements/Scenes/ProgressBar and Sliders.unity
Assets/Simple UI Elements/Scenes/ProgressBar and Sliders.unity.meta
Assets/Simple UI Elements/Scenes/ProgressBar and SlidersSettings.lighting
Assets/Simple UI Elements/Scenes/ProgressBar and SlidersSettings.lighting.meta
Assets/Simple UI Elements/UI Elements.meta
Assets/Simple UI Elements/UI Elements/Black.meta
Assets/Simple UI Elements/UI Elements/Black/1x.meta
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton 1.png
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton 1.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton 2.png
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton 2.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton 3.png
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton 3.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton A.png
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton A.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton B.png
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton B.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton C.png
Assets/Simple UI Elements/UI Elements/Black/1x/BUtton C.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/Leaderboard.png
Assets/Simple UI Elements/UI Elements/Black/1x/Leaderboard.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/backward.png
Assets/Simple UI Elements/UI Elements/Black/1x/backward.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/camera.png
Assets/Simple UI Elements/UI Elements/Black/1x/camera.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/cross.png
Assets/Simple UI Elements/UI Elements/Black/1x/cross.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/down arrow.png
Assets/Simple UI Elements/UI Elements/Black/1x/down arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/exit left.png
Assets/Simple UI Elements/UI Elements/Black/1x/exit left.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/exit right.png
Assets/Simple UI Elements/UI Elements/Black/1x/exit right.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/forward.png
Assets/Simple UI Elements/UI Elements/Black/1x/forward.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/gamepad1.png
Assets/Simple UI Elements/UI Elements/Black/1x/gamepad1.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/gamepad2.png
Assets/Simple UI Elements/UI Elements/Black/1x/gamepad2.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/hamburger icon.png
Assets/Simple UI Elements/UI Elements/Black/1x/hamburger icon.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/home.png
Assets/Simple UI Elements/UI Elements/Black/1x/home.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/info.png
Assets/Simple UI Elements/UI Elements/Black/1x/info.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/left arrow.png
Assets/Simple UI Elements/UI Elements/Black/1x/left arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/left.png
Assets/Simple UI Elements/UI Elements/Black/1x/left.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/lock.png
Assets/Simple UI Elements/UI Elements/Black/1x/lock.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/menu1.png
Assets/Simple UI Elements/UI Elements/Black/1x/menu1.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/menu2.png
Assets/Simple UI Elements/UI Elements/Black/1x/menu2.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/mic off.png
Assets/Simple UI Elements/UI Elements/Black/1x/mic off.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/mic on.png
Assets/Simple UI Elements/UI Elements/Black/1x/mic on.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/music off.png
Assets/Simple UI Elements/UI Elements/Black/1x/music off.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/music on.png
Assets/Simple UI Elements/UI Elements/Black/1x/music on.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/noet-west arrow.png
Assets/Simple UI Elements/UI Elements/Black/1x/noet-west arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/north-east arrow.png
Assets/Simple UI Elements/UI Elements/Black/1x/north-east arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/pause.png
Assets/Simple UI Elements/UI Elements/Black/1x/pause.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/right arrow.png
Assets/Simple UI Elements/UI Elements/Black/1x/right arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/right.png
Assets/Simple UI Elements/UI Elements/Black/1x/right.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/settings.png
Assets/Simple UI Elements/UI Elements/Black/1x/settings.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/share.png
Assets/Simple UI Elements/UI Elements/Black/1x/share.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/sign1.png
Assets/Simple UI Elements/UI Elements/Black/1x/sign1.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/sign2.png
Assets/Simple UI Elements/UI Elements/Black/1x/sign2.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/south-east arrow.png
Assets/Simple UI Elements/UI Elements/Black/1x/south-east arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/south-west arrow.png
Assets/Simple UI Elements/UI Elements/Black/1x/south-west arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/star.png
Assets/Simple UI Elements/UI Elements/Black/1x/star.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/stop.png
Assets/Simple UI Elements/UI Elements/Black/1x/stop.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/unlock.png
Assets/Simple UI Elements/UI Elements/Black/1x/unlock.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/up arrow.png
Assets/Simple UI Elements/UI Elements/Black/1x/up arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/up.png
Assets/Simple UI Elements/UI Elements/Black/1x/up.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/video.png
Assets/Simple UI Elements/UI Elements/Black/1x/video.png.meta
Assets/Simple UI Elements/UI Elements/Black/1x/yes-tic.png
Assets/Simple UI Elements/UI Elements/Black/1x/yes-tic.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x.meta
Assets/Simple UI Elements/UI Elements/Black/2x/Button 1.png
Assets/Simple UI Elements/UI Elements/Black/2x/Button 1.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/Button 2.png
Assets/Simple UI Elements/UI Elements/Black/2x/Button 2.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/Button 3.png
Assets/Simple UI Elements/UI Elements/Black/2x/Button 3.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/Button A.png
Assets/Simple UI Elements/UI Elements/Black/2x/Button A.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/Button B.png
Assets/Simple UI Elements/UI Elements/Black/2x/Button B.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/Button C.png
Assets/Simple UI Elements/UI Elements/Black/2x/Button C.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/backward.png
Assets/Simple UI Elements/UI Elements/Black/2x/backward.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/camera.png
Assets/Simple UI Elements/UI Elements/Black/2x/camera.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/cross.png
Assets/Simple UI Elements/UI Elements/Black/2x/cross.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/down arrow.png
Assets/Simple UI Elements/UI Elements/Black/2x/down arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/down.png
Assets/Simple UI Elements/UI Elements/Black/2x/down.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/forward.png
Assets/Simple UI Elements/UI Elements/Black/2x/forward.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/gamepad1.png
Assets/Simple UI Elements/UI Elements/Black/2x/gamepad1.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/gamepad2.png
Assets/Simple UI Elements/UI Elements/Black/2x/gamepad2.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/hamburger icon.png
Assets/Simple UI Elements/UI Elements/Black/2x/hamburger icon.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/home.png
Assets/Simple UI Elements/UI Elements/Black/2x/home.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/info.png
Assets/Simple UI Elements/UI Elements/Black/2x/info.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/leaderboard.png
Assets/Simple UI Elements/UI Elements/Black/2x/leaderboard.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/left arrow.png
Assets/Simple UI Elements/UI Elements/Black/2x/left arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/left exit.png
Assets/Simple UI Elements/UI Elements/Black/2x/left exit.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/left.png
Assets/Simple UI Elements/UI Elements/Black/2x/left.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/lock.png
Assets/Simple UI Elements/UI Elements/Black/2x/lock.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/menu1.png
Assets/Simple UI Elements/UI Elements/Black/2x/menu1.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/menu2.png
Assets/Simple UI Elements/UI Elements/Black/2x/menu2.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/mic off.png
Assets/Simple UI Elements/UI Elements/Black/2x/mic off.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/mic on.png
Assets/Simple UI Elements/UI Elements/Black/2x/mic on.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/music off.png
Assets/Simple UI Elements/UI Elements/Black/2x/music off.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/music on.png
Assets/Simple UI Elements/UI Elements/Black/2x/music on.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/north east arrow.png
Assets/Simple UI Elements/UI Elements/Black/2x/north east arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/north-west arrow.png
Assets/Simple UI Elements/UI Elements/Black/2x/north-west arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/pause.png
Assets/Simple UI Elements/UI Elements/Black/2x/pause.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/right arrow.png
Assets/Simple UI Elements/UI Elements/Black/2x/right arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/right exit.png
Assets/Simple UI Elements/UI Elements/Black/2x/right exit.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/right.png
Assets/Simple UI Elements/UI Elements/Black/2x/right.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/settings.png
Assets/Simple UI Elements/UI Elements/Black/2x/settings.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/share.png
Assets/Simple UI Elements/UI Elements/Black/2x/share.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/sign1.png
Assets/Simple UI Elements/UI Elements/Black/2x/sign1.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/sign2.png
Assets/Simple UI Elements/UI Elements/Black/2x/sign2.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/south-east arrow.png
Assets/Simple UI Elements/UI Elements/Black/2x/south-east arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/south-west arrow.png
Assets/Simple UI Elements/UI Elements/Black/2x/south-west arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/star.png
Assets/Simple UI Elements/UI Elements/Black/2x/star.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/stop.png
Assets/Simple UI Elements/UI Elements/Black/2x/stop.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/unlock.png
Assets/Simple UI Elements/UI Elements/Black/2x/unlock.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/up arrow.png
Assets/Simple UI Elements/UI Elements/Black/2x/up arrow.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/up.png
Assets/Simple UI Elements/UI Elements/Black/2x/up.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/video.png
Assets/Simple UI Elements/UI Elements/Black/2x/video.png.meta
Assets/Simple UI Elements/UI Elements/Black/2x/yes-tic.png
Assets/Simple UI Elements/UI Elements/Black/2x/yes-tic.png.meta
Assets/Simple UI Elements/UI Elements/Extras.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle128.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle128/circle128.png
Assets/Simple UI Elements/UI Elements/Extras/Circle128/circle128.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle128/circlefill2px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle128/circlefill2px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle128/circlefill4px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle128/circlefill4px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle128/circlefill8px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle128/circlefill8px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle256.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle256/circle256.png
Assets/Simple UI Elements/UI Elements/Extras/Circle256/circle256.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle256/circlefillRy16px256px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle256/circlefillRy16px256px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle256/circlefillRy32px256px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle256/circlefillRy32px256px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle256/circlefillRy8px256px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle256/circlefillRy8px256px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle512.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle512/circle512.png
Assets/Simple UI Elements/UI Elements/Extras/Circle512/circle512.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle512/circlefillRy15px512px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle512/circlefillRy15px512px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle512/circlefillRy30px512px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle512/circlefillRy30px512px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Circle512/circlefillRy86px512px.png
Assets/Simple UI Elements/UI Elements/Extras/Circle512/circlefillRy86px512px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars.meta
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/Starprogress.png
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/Starprogress.png.meta
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/loading1.png
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/loading1.png.meta
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/loading2.png
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/loading2.png.meta
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/progressBar1.png
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/progressBar1.png.meta
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/progressBar2.png
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/progressBar2.png.meta
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/progressBar3.png
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/progressBar3.png.meta
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/progressBar4.png
Assets/Simple UI Elements/UI Elements/Extras/ProgressBars/progressBar4.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/SquareRy8.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/SquareRy8.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/rect3pxRy8.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/rect3pxRy8.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/rect4pxRy8.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/rect4pxRy8.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/rect8pxRy8.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/rect8pxRy8.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/rectRy8.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/rectRy8.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/roundRect.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/roundRect.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/roundRect2px.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/roundRect2px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/roundRect4px.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/roundRect4px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/Rects/roundRect8px.png
Assets/Simple UI Elements/UI Elements/Extras/Rects/roundRect8px.png.meta
Assets/Simple UI Elements/UI Elements/Extras/circle64.png
Assets/Simple UI Elements/UI Elements/Extras/circle64.png.meta
Assets/Simple UI Elements/UI Elements/White.meta
Assets/Simple UI Elements/UI Elements/White/1x.meta
Assets/Simple UI Elements/UI Elements/White/1x/BUtton 1.png
Assets/Simple UI Elements/UI Elements/White/1x/BUtton 1.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/BUtton 2.png
Assets/Simple UI Elements/UI Elements/White/1x/BUtton 2.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/BUtton 3.png
Assets/Simple UI Elements/UI Elements/White/1x/BUtton 3.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/BUtton A.png
Assets/Simple UI Elements/UI Elements/White/1x/BUtton A.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/BUtton B.png
Assets/Simple UI Elements/UI Elements/White/1x/BUtton B.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/BUtton C.png
Assets/Simple UI Elements/UI Elements/White/1x/BUtton C.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/Leaderboard.png
Assets/Simple UI Elements/UI Elements/White/1x/Leaderboard.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/backward.png
Assets/Simple UI Elements/UI Elements/White/1x/backward.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/camera.png
Assets/Simple UI Elements/UI Elements/White/1x/camera.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/cross.png
Assets/Simple UI Elements/UI Elements/White/1x/cross.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/down arrow.png
Assets/Simple UI Elements/UI Elements/White/1x/down arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/down.png
Assets/Simple UI Elements/UI Elements/White/1x/down.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/exit left.png
Assets/Simple UI Elements/UI Elements/White/1x/exit left.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/exit right.png
Assets/Simple UI Elements/UI Elements/White/1x/exit right.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/forward.png
Assets/Simple UI Elements/UI Elements/White/1x/forward.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/gamepad1.png
Assets/Simple UI Elements/UI Elements/White/1x/gamepad1.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/gamepad2.png
Assets/Simple UI Elements/UI Elements/White/1x/gamepad2.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/hamburger icon.png
Assets/Simple UI Elements/UI Elements/White/1x/hamburger icon.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/home.png
Assets/Simple UI Elements/UI Elements/White/1x/home.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/info.png
Assets/Simple UI Elements/UI Elements/White/1x/info.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/left arrow.png
Assets/Simple UI Elements/UI Elements/White/1x/left arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/left.png
Assets/Simple UI Elements/UI Elements/White/1x/left.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/lock.png
Assets/Simple UI Elements/UI Elements/White/1x/lock.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/menu1.png
Assets/Simple UI Elements/UI Elements/White/1x/menu1.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/menu2.png
Assets/Simple UI Elements/UI Elements/White/1x/menu2.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/mic off.png
Assets/Simple UI Elements/UI Elements/White/1x/mic off.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/mic on.png
Assets/Simple UI Elements/UI Elements/White/1x/mic on.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/music off.png
Assets/Simple UI Elements/UI Elements/White/1x/music off.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/music on.png
Assets/Simple UI Elements/UI Elements/White/1x/music on.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/noet-west arrow.png
Assets/Simple UI Elements/UI Elements/White/1x/noet-west arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/north-east arrow.png
Assets/Simple UI Elements/UI Elements/White/1x/north-east arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/pause.png
Assets/Simple UI Elements/UI Elements/White/1x/pause.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/right arrow.png
Assets/Simple UI Elements/UI Elements/White/1x/right arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/right.png
Assets/Simple UI Elements/UI Elements/White/1x/right.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/settings.png
Assets/Simple UI Elements/UI Elements/White/1x/settings.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/share.png
Assets/Simple UI Elements/UI Elements/White/1x/share.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/sign1.png
Assets/Simple UI Elements/UI Elements/White/1x/sign1.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/sign2.png
Assets/Simple UI Elements/UI Elements/White/1x/sign2.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/south-east arrow.png
Assets/Simple UI Elements/UI Elements/White/1x/south-east arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/south-west arrow.png
Assets/Simple UI Elements/UI Elements/White/1x/south-west arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/star.png
Assets/Simple UI Elements/UI Elements/White/1x/star.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/stop.png
Assets/Simple UI Elements/UI Elements/White/1x/stop.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/unlock.png
Assets/Simple UI Elements/UI Elements/White/1x/unlock.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/up arrow.png
Assets/Simple UI Elements/UI Elements/White/1x/up arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/up.png
Assets/Simple UI Elements/UI Elements/White/1x/up.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/video.png
Assets/Simple UI Elements/UI Elements/White/1x/video.png.meta
Assets/Simple UI Elements/UI Elements/White/1x/yes-tic.png
Assets/Simple UI Elements/UI Elements/White/1x/yes-tic.png.meta
Assets/Simple UI Elements/UI Elements/White/2x.meta
Assets/Simple UI Elements/UI Elements/White/2x/Button 1.png
Assets/Simple UI Elements/UI Elements/White/2x/Button 1.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/Button 2.png
Assets/Simple UI Elements/UI Elements/White/2x/Button 2.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/Button 3.png
Assets/Simple UI Elements/UI Elements/White/2x/Button 3.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/Button A.png
Assets/Simple UI Elements/UI Elements/White/2x/Button A.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/Button B.png
Assets/Simple UI Elements/UI Elements/White/2x/Button B.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/Button C.png
Assets/Simple UI Elements/UI Elements/White/2x/Button C.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/backward.png
Assets/Simple UI Elements/UI Elements/White/2x/backward.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/camera.png
Assets/Simple UI Elements/UI Elements/White/2x/camera.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/cross.png
Assets/Simple UI Elements/UI Elements/White/2x/cross.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/down arrow.png
Assets/Simple UI Elements/UI Elements/White/2x/down arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/down.png
Assets/Simple UI Elements/UI Elements/White/2x/down.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/forward.png
Assets/Simple UI Elements/UI Elements/White/2x/forward.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/gamepad1.png
Assets/Simple UI Elements/UI Elements/White/2x/gamepad1.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/gamepad2.png
Assets/Simple UI Elements/UI Elements/White/2x/gamepad2.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/hamburger icon.png
Assets/Simple UI Elements/UI Elements/White/2x/hamburger icon.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/home.png
Assets/Simple UI Elements/UI Elements/White/2x/home.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/info.png
Assets/Simple UI Elements/UI Elements/White/2x/info.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/leaderboard.png
Assets/Simple UI Elements/UI Elements/White/2x/leaderboard.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/left arrow.png
Assets/Simple UI Elements/UI Elements/White/2x/left arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/left exit.png
Assets/Simple UI Elements/UI Elements/White/2x/left exit.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/left.png
Assets/Simple UI Elements/UI Elements/White/2x/left.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/lock.png
Assets/Simple UI Elements/UI Elements/White/2x/lock.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/menu1.png
Assets/Simple UI Elements/UI Elements/White/2x/menu1.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/menu2.png
Assets/Simple UI Elements/UI Elements/White/2x/menu2.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/mic off.png
Assets/Simple UI Elements/UI Elements/White/2x/mic off.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/mic on.png
Assets/Simple UI Elements/UI Elements/White/2x/mic on.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/music off.png
Assets/Simple UI Elements/UI Elements/White/2x/music off.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/music on.png
Assets/Simple UI Elements/UI Elements/White/2x/music on.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/north east arrow.png
Assets/Simple UI Elements/UI Elements/White/2x/north east arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/north-west arrow.png
Assets/Simple UI Elements/UI Elements/White/2x/north-west arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/pause.png
Assets/Simple UI Elements/UI Elements/White/2x/pause.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/right arrow.png
Assets/Simple UI Elements/UI Elements/White/2x/right arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/right exit.png
Assets/Simple UI Elements/UI Elements/White/2x/right exit.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/right.png
Assets/Simple UI Elements/UI Elements/White/2x/right.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/settings.png
Assets/Simple UI Elements/UI Elements/White/2x/settings.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/share.png
Assets/Simple UI Elements/UI Elements/White/2x/share.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/sign1.png
Assets/Simple UI Elements/UI Elements/White/2x/sign1.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/sign2.png
Assets/Simple UI Elements/UI Elements/White/2x/sign2.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/south-east arrow.png
Assets/Simple UI Elements/UI Elements/White/2x/south-east arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/south-west arrow.png
Assets/Simple UI Elements/UI Elements/White/2x/south-west arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/star.png
Assets/Simple UI Elements/UI Elements/White/2x/star.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/stop.png
Assets/Simple UI Elements/UI Elements/White/2x/stop.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/unlock.png
Assets/Simple UI Elements/UI Elements/White/2x/unlock.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/up arrow.png
Assets/Simple UI Elements/UI Elements/White/2x/up arrow.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/up.png
Assets/Simple UI Elements/UI Elements/White/2x/up.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/video.png
Assets/Simple UI Elements/UI Elements/White/2x/video.png.meta
Assets/Simple UI Elements/UI Elements/White/2x/yes-tic.png
Assets/Simple UI Elements/UI Elements/White/2x/yes-tic.png.meta
Assets/SimpleLowPolyNature/Lowpoly Demo Post-processing Profile.asset
Assets/SimpleLowPolyNature/Lowpoly Demo Post-processing Profile.asset.meta
Assets/SimpleLowPolyNature/Materials.meta
Assets/SimpleLowPolyNature/Materials/CloudMat.mat
Assets/SimpleLowPolyNature/Materials/CloudMat.mat.meta
Assets/SimpleLowPolyNature/Materials/DemoPlaneMat.mat
Assets/SimpleLowPolyNature/Materials/DemoPlaneMat.mat.meta
Assets/SimpleLowPolyNature/Materials/EmissionBlueMat.mat
Assets/SimpleLowPolyNature/Materials/EmissionBlueMat.mat.meta
Assets/SimpleLowPolyNature/Materials/EmissionYellowMat.mat
Assets/SimpleLowPolyNature/Materials/EmissionYellowMat.mat.meta
Assets/SimpleLowPolyNature/Materials/FireParticleAddMat.mat
Assets/SimpleLowPolyNature/Materials/FireParticleAddMat.mat.meta
Assets/SimpleLowPolyNature/Materials/FireParticleMat.mat
Assets/SimpleLowPolyNature/Materials/FireParticleMat.mat.meta
Assets/SimpleLowPolyNature/Materials/Flower1Mat.mat
Assets/SimpleLowPolyNature/Materials/Flower1Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/Flower2Mat.mat
Assets/SimpleLowPolyNature/Materials/Flower2Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/Flower3Mat.mat
Assets/SimpleLowPolyNature/Materials/Flower3Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/Flower4Mat.mat
Assets/SimpleLowPolyNature/Materials/Flower4Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/Mushroom1Mat.mat
Assets/SimpleLowPolyNature/Materials/Mushroom1Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/Mushroom2Mat.mat
Assets/SimpleLowPolyNature/Materials/Mushroom2Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/Mushroom3Mat.mat
Assets/SimpleLowPolyNature/Materials/Mushroom3Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/PlantMat.mat
Assets/SimpleLowPolyNature/Materials/PlantMat.mat.meta
Assets/SimpleLowPolyNature/Materials/RockMat.mat
Assets/SimpleLowPolyNature/Materials/RockMat.mat.meta
Assets/SimpleLowPolyNature/Materials/TreeGreen1Mat.mat
Assets/SimpleLowPolyNature/Materials/TreeGreen1Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/TreeGreen2Mat.mat
Assets/SimpleLowPolyNature/Materials/TreeGreen2Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/TreeOrangeMat.mat
Assets/SimpleLowPolyNature/Materials/TreeOrangeMat.mat.meta
Assets/SimpleLowPolyNature/Materials/TreePinkMat.mat
Assets/SimpleLowPolyNature/Materials/TreePinkMat.mat.meta
Assets/SimpleLowPolyNature/Materials/TreeRedMat.mat
Assets/SimpleLowPolyNature/Materials/TreeRedMat.mat.meta
Assets/SimpleLowPolyNature/Materials/TreeYellowMat.mat
Assets/SimpleLowPolyNature/Materials/TreeYellowMat.mat.meta
Assets/SimpleLowPolyNature/Materials/WaterMat.mat
Assets/SimpleLowPolyNature/Materials/WaterMat.mat.meta
Assets/SimpleLowPolyNature/Materials/Wood1Mat.mat
Assets/SimpleLowPolyNature/Materials/Wood1Mat.mat.meta
Assets/SimpleLowPolyNature/Materials/Wood2Mat.mat
Assets/SimpleLowPolyNature/Materials/Wood2Mat.mat.meta
Assets/SimpleLowPolyNature/Models.meta
Assets/SimpleLowPolyNature/Models/Cloud1.fbx
Assets/SimpleLowPolyNature/Models/Cloud1.fbx.meta
Assets/SimpleLowPolyNature/Models/Cloud2.fbx
Assets/SimpleLowPolyNature/Models/Cloud2.fbx.meta
Assets/SimpleLowPolyNature/Models/FallenBranch.fbx
Assets/SimpleLowPolyNature/Models/FallenBranch.fbx.meta
Assets/SimpleLowPolyNature/Models/FireParticle.fbx
Assets/SimpleLowPolyNature/Models/FireParticle.fbx.meta
Assets/SimpleLowPolyNature/Models/FireWood.fbx
Assets/SimpleLowPolyNature/Models/FireWood.fbx.meta
Assets/SimpleLowPolyNature/Models/Flower1.fbx
Assets/SimpleLowPolyNature/Models/Flower1.fbx.meta
Assets/SimpleLowPolyNature/Models/Flower2.fbx
Assets/SimpleLowPolyNature/Models/Flower2.fbx.meta
Assets/SimpleLowPolyNature/Models/Flower3.fbx
Assets/SimpleLowPolyNature/Models/Flower3.fbx.meta
Assets/SimpleLowPolyNature/Models/Grass1.fbx
Assets/SimpleLowPolyNature/Models/Grass1.fbx.meta
Assets/SimpleLowPolyNature/Models/Grass2.fbx
Assets/SimpleLowPolyNature/Models/Grass2.fbx.meta
Assets/SimpleLowPolyNature/Models/Grass3.fbx
Assets/SimpleLowPolyNature/Models/Grass3.fbx.meta
Assets/SimpleLowPolyNature/Models/Grass4.fbx
Assets/SimpleLowPolyNature/Models/Grass4.fbx.meta
Assets/SimpleLowPolyNature/Models/Ivy1.fbx
Assets/SimpleLowPolyNature/Models/Ivy1.fbx.meta
Assets/SimpleLowPolyNature/Models/Ivy2.fbx
Assets/SimpleLowPolyNature/Models/Ivy2.fbx.meta
Assets/SimpleLowPolyNature/Models/LightingPlant1.fbx
Assets/SimpleLowPolyNature/Models/LightingPlant1.fbx.meta
Assets/SimpleLowPolyNature/Models/LightingPlant2.fbx
Assets/SimpleLowPolyNature/Models/LightingPlant2.fbx.meta
Assets/SimpleLowPolyNature/Models/Log.fbx
Assets/SimpleLowPolyNature/Models/Log.fbx.meta
Assets/SimpleLowPolyNature/Models/LowpolyTerrain.fbx
Assets/SimpleLowPolyNature/Models/LowpolyTerrain.fbx.meta
Assets/SimpleLowPolyNature/Models/Mushroom1.fbx
Assets/SimpleLowPolyNature/Models/Mushroom1.fbx.meta
Assets/SimpleLowPolyNature/Models/Mushroom2.fbx
Assets/SimpleLowPolyNature/Models/Mushroom2.fbx.meta
Assets/SimpleLowPolyNature/Models/MushroomLarge.fbx
Assets/SimpleLowPolyNature/Models/MushroomLarge.fbx.meta
Assets/SimpleLowPolyNature/Models/Paddle.fbx
Assets/SimpleLowPolyNature/Models/Paddle.fbx.meta
Assets/SimpleLowPolyNature/Models/Plant1.fbx
Assets/SimpleLowPolyNature/Models/Plant1.fbx.meta
Assets/SimpleLowPolyNature/Models/Plant2.fbx
Assets/SimpleLowPolyNature/Models/Plant2.fbx.meta
Assets/SimpleLowPolyNature/Models/Plant3.fbx
Assets/SimpleLowPolyNature/Models/Plant3.fbx.meta
Assets/SimpleLowPolyNature/Models/Plant4.fbx
Assets/SimpleLowPolyNature/Models/Plant4.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock1.fbx
Assets/SimpleLowPolyNature/Models/Rock1.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock10.fbx
Assets/SimpleLowPolyNature/Models/Rock10.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock11.fbx
Assets/SimpleLowPolyNature/Models/Rock11.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock12.fbx
Assets/SimpleLowPolyNature/Models/Rock12.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock2.fbx
Assets/SimpleLowPolyNature/Models/Rock2.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock3.fbx
Assets/SimpleLowPolyNature/Models/Rock3.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock4.fbx
Assets/SimpleLowPolyNature/Models/Rock4.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock5.fbx
Assets/SimpleLowPolyNature/Models/Rock5.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock6.fbx
Assets/SimpleLowPolyNature/Models/Rock6.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock7.fbx
Assets/SimpleLowPolyNature/Models/Rock7.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock8.fbx
Assets/SimpleLowPolyNature/Models/Rock8.fbx.meta
Assets/SimpleLowPolyNature/Models/Rock9.fbx
Assets/SimpleLowPolyNature/Models/Rock9.fbx.meta
Assets/SimpleLowPolyNature/Models/Tent.fbx
Assets/SimpleLowPolyNature/Models/Tent.fbx.meta
Assets/SimpleLowPolyNature/Models/Tree1.fbx
Assets/SimpleLowPolyNature/Models/Tree1.fbx.meta
Assets/SimpleLowPolyNature/Models/Tree2.fbx
Assets/SimpleLowPolyNature/Models/Tree2.fbx.meta
Assets/SimpleLowPolyNature/Models/Tree3.fbx
Assets/SimpleLowPolyNature/Models/Tree3.fbx.meta
Assets/SimpleLowPolyNature/Models/TreeDead1.fbx
Assets/SimpleLowPolyNature/Models/TreeDead1.fbx.meta
Assets/SimpleLowPolyNature/Models/TreeDead2.fbx
Assets/SimpleLowPolyNature/Models/TreeDead2.fbx.meta
Assets/SimpleLowPolyNature/Models/TreeStump1.fbx
Assets/SimpleLowPolyNature/Models/TreeStump1.fbx.meta
Assets/SimpleLowPolyNature/Models/WoodBoat.fbx
Assets/SimpleLowPolyNature/Models/WoodBoat.fbx.meta
Assets/SimpleLowPolyNature/Models/WoodFence1.fbx
Assets/SimpleLowPolyNature/Models/WoodFence1.fbx.meta
Assets/SimpleLowPolyNature/Models/WoodFence2.fbx
Assets/SimpleLowPolyNature/Models/WoodFence2.fbx.meta
Assets/SimpleLowPolyNature/Prefabs.meta
Assets/SimpleLowPolyNature/Prefabs/CampFire.prefab
Assets/SimpleLowPolyNature/Prefabs/CampFire.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Cloud1.prefab
Assets/SimpleLowPolyNature/Prefabs/Cloud1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Cloud2.prefab
Assets/SimpleLowPolyNature/Prefabs/Cloud2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Clouds1Layer.prefab
Assets/SimpleLowPolyNature/Prefabs/Clouds1Layer.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Clouds2Layer.prefab
Assets/SimpleLowPolyNature/Prefabs/Clouds2Layer.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/FallenBranch.prefab
Assets/SimpleLowPolyNature/Prefabs/FallenBranch.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Flower1.prefab
Assets/SimpleLowPolyNature/Prefabs/Flower1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Flower2.prefab
Assets/SimpleLowPolyNature/Prefabs/Flower2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Flower3.prefab
Assets/SimpleLowPolyNature/Prefabs/Flower3.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Flower4.prefab
Assets/SimpleLowPolyNature/Prefabs/Flower4.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Grass1.prefab
Assets/SimpleLowPolyNature/Prefabs/Grass1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Grass2.prefab
Assets/SimpleLowPolyNature/Prefabs/Grass2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Grass3.prefab
Assets/SimpleLowPolyNature/Prefabs/Grass3.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Grass4.prefab
Assets/SimpleLowPolyNature/Prefabs/Grass4.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Ivy1.prefab
Assets/SimpleLowPolyNature/Prefabs/Ivy1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Ivy2.prefab
Assets/SimpleLowPolyNature/Prefabs/Ivy2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/LightingPlant1.prefab
Assets/SimpleLowPolyNature/Prefabs/LightingPlant1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/LightingPlant2.prefab
Assets/SimpleLowPolyNature/Prefabs/LightingPlant2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Log.prefab
Assets/SimpleLowPolyNature/Prefabs/Log.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Mushroom1.prefab
Assets/SimpleLowPolyNature/Prefabs/Mushroom1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Mushroom2.prefab
Assets/SimpleLowPolyNature/Prefabs/Mushroom2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Mushroom3.prefab
Assets/SimpleLowPolyNature/Prefabs/Mushroom3.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/MushroomLarge.prefab
Assets/SimpleLowPolyNature/Prefabs/MushroomLarge.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Paddle.prefab
Assets/SimpleLowPolyNature/Prefabs/Paddle.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/PlantEx1.prefab
Assets/SimpleLowPolyNature/Prefabs/PlantEx1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/PlantEx2.prefab
Assets/SimpleLowPolyNature/Prefabs/PlantEx2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/PlantEx3.prefab
Assets/SimpleLowPolyNature/Prefabs/PlantEx3.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/PlantEx4.prefab
Assets/SimpleLowPolyNature/Prefabs/PlantEx4.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock1.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock10.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock10.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock11.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock11.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock12.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock12.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock2.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock3.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock3.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock4.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock4.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock5.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock5.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock6.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock6.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock7.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock7.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock8.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock8.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Rock9.prefab
Assets/SimpleLowPolyNature/Prefabs/Rock9.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Tent.prefab
Assets/SimpleLowPolyNature/Prefabs/Tent.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Tree1.prefab
Assets/SimpleLowPolyNature/Prefabs/Tree1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Tree2.prefab
Assets/SimpleLowPolyNature/Prefabs/Tree2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Tree3.prefab
Assets/SimpleLowPolyNature/Prefabs/Tree3.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/TreeDead1.prefab
Assets/SimpleLowPolyNature/Prefabs/TreeDead1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/TreeDead2.prefab
Assets/SimpleLowPolyNature/Prefabs/TreeDead2.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/TreePink1.prefab
Assets/SimpleLowPolyNature/Prefabs/TreePink1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/TreePink3.prefab
Assets/SimpleLowPolyNature/Prefabs/TreePink3.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/TreeStump.prefab
Assets/SimpleLowPolyNature/Prefabs/TreeStump.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/TreeYellow1.prefab
Assets/SimpleLowPolyNature/Prefabs/TreeYellow1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/TreeYellow3.prefab
Assets/SimpleLowPolyNature/Prefabs/TreeYellow3.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/Water.prefab
Assets/SimpleLowPolyNature/Prefabs/Water.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/WoodBoat.prefab
Assets/SimpleLowPolyNature/Prefabs/WoodBoat.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/WoodFence1.prefab
Assets/SimpleLowPolyNature/Prefabs/WoodFence1.prefab.meta
Assets/SimpleLowPolyNature/Prefabs/WoodFence2.prefab
Assets/SimpleLowPolyNature/Prefabs/WoodFence2.prefab.meta
Assets/SimpleLowPolyNature/Readme.txt
Assets/SimpleLowPolyNature/Readme.txt.meta
Assets/SimpleLowPolyNature/Scenes.meta
Assets/SimpleLowPolyNature/Scenes/DemoDay.meta
Assets/SimpleLowPolyNature/Scenes/DemoDay.unity
Assets/SimpleLowPolyNature/Scenes/DemoDay.unity.meta
Assets/SimpleLowPolyNature/Scenes/DemoNight.meta
Assets/SimpleLowPolyNature/Scenes/DemoNight.unity
Assets/SimpleLowPolyNature/Scenes/DemoNight.unity.meta
Assets/SimpleLowPolyNature/Scenes/PrefabsScene.meta
Assets/SimpleLowPolyNature/Scenes/PrefabsScene.unity
Assets/SimpleLowPolyNature/Scenes/PrefabsScene.unity.meta
Assets/SimpleLowPolyNature/Scenes/PrefabsScene/Lightmap-1_comp_dir.png
Assets/SimpleLowPolyNature/Scenes/PrefabsScene/Lightmap-1_comp_dir.png.meta
Assets/SimpleLowPolyNature/Scenes/PrefabsScene/Lightmap-1_comp_light.exr
Assets/SimpleLowPolyNature/Scenes/PrefabsScene/Lightmap-1_comp_light.exr.meta
Assets/SimpleLowPolyNature/Scenes/SceneDemoAsset.meta
Assets/SimpleLowPolyNature/Scenes/SceneDemoAsset/LowpolyTerrain.prefab
Assets/SimpleLowPolyNature/Scenes/SceneDemoAsset/LowpolyTerrain.prefab.meta
Assets/SimpleLowPolyNature/Shaders.meta
Assets/SimpleLowPolyNature/Shaders/SimpleWater.shader
Assets/SimpleLowPolyNature/Shaders/SimpleWater.shader.meta
Assets/TextMesh Pro.meta
Assets/TextMesh Pro/Fonts.meta
Assets/TextMesh Pro/Fonts/LiberationSans - OFL.txt
Assets/TextMesh Pro/Fonts/LiberationSans - OFL.txt.meta
Assets/TextMesh Pro/Fonts/LiberationSans.ttf
Assets/TextMesh Pro/Fonts/LiberationSans.ttf.meta
Assets/TextMesh Pro/Resources.meta
Assets/TextMesh Pro/Resources/Fonts & Materials.meta
Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Drop Shadow.mat
Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Drop Shadow.mat.meta
Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Fallback.asset
Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Fallback.asset.meta
Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Outline.mat
Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Outline.mat.meta
Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset
Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset.meta
Assets/TextMesh Pro/Resources/LineBreaking Following Characters.txt
Assets/TextMesh Pro/Resources/LineBreaking Following Characters.txt.meta
Assets/TextMesh Pro/Resources/LineBreaking Leading Characters.txt
Assets/TextMesh Pro/Resources/LineBreaking Leading Characters.txt.meta
Assets/TextMesh Pro/Resources/Sprite Assets.meta
Assets/TextMesh Pro/Resources/Sprite Assets/EmojiOne.asset
Assets/TextMesh Pro/Resources/Sprite Assets/EmojiOne.asset.meta
Assets/TextMesh Pro/Resources/Style Sheets.meta
Assets/TextMesh Pro/Resources/Style Sheets/Default Style Sheet.asset
Assets/TextMesh Pro/Resources/Style Sheets/Default Style Sheet.asset.meta
Assets/TextMesh Pro/Resources/TMP Settings.asset
Assets/TextMesh Pro/Resources/TMP Settings.asset.meta
Assets/TextMesh Pro/Shaders.meta
Assets/TextMesh Pro/Shaders/SDFFunctions.hlsl
Assets/TextMesh Pro/Shaders/SDFFunctions.hlsl.meta
Assets/TextMesh Pro/Shaders/TMP_Bitmap-Custom-Atlas.shader
Assets/TextMesh Pro/Shaders/TMP_Bitmap-Custom-Atlas.shader.meta
Assets/TextMesh Pro/Shaders/TMP_Bitmap-Mobile.shader
Assets/TextMesh Pro/Shaders/TMP_Bitmap-Mobile.shader.meta
Assets/TextMesh Pro/Shaders/TMP_Bitmap.shader
Assets/TextMesh Pro/Shaders/TMP_Bitmap.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF Overlay.shader
Assets/TextMesh Pro/Shaders/TMP_SDF Overlay.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF SSD.shader
Assets/TextMesh Pro/Shaders/TMP_SDF SSD.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-HDRP LIT.shadergraph
Assets/TextMesh Pro/Shaders/TMP_SDF-HDRP LIT.shadergraph.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-HDRP UNLIT.shadergraph
Assets/TextMesh Pro/Shaders/TMP_SDF-HDRP UNLIT.shadergraph.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile Masking.shader
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile Masking.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile Overlay.shader
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile Overlay.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile SSD.shader
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile SSD.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile-2-Pass.shader
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile-2-Pass.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile.shader
Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-Surface-Mobile.shader
Assets/TextMesh Pro/Shaders/TMP_SDF-Surface-Mobile.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-Surface.shader
Assets/TextMesh Pro/Shaders/TMP_SDF-Surface.shader.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-URP Lit.shadergraph
Assets/TextMesh Pro/Shaders/TMP_SDF-URP Lit.shadergraph.meta
Assets/TextMesh Pro/Shaders/TMP_SDF-URP Unlit.shadergraph
Assets/TextMesh Pro/Shaders/TMP_SDF-URP Unlit.shadergraph.meta
Assets/TextMesh Pro/Shaders/TMP_SDF.shader
Assets/TextMesh Pro/Shaders/TMP_SDF.shader.meta
Assets/TextMesh Pro/Shaders/TMP_Sprite.shader
Assets/TextMesh Pro/Shaders/TMP_Sprite.shader.meta
Assets/TextMesh Pro/Shaders/TMPro.cginc
Assets/TextMesh Pro/Shaders/TMPro.cginc.meta
Assets/TextMesh Pro/Shaders/TMPro_Mobile.cginc
Assets/TextMesh Pro/Shaders/TMPro_Mobile.cginc.meta
Assets/TextMesh Pro/Shaders/TMPro_Properties.cginc
Assets/TextMesh Pro/Shaders/TMPro_Properties.cginc.meta
Assets/TextMesh Pro/Shaders/TMPro_Surface.cginc
Assets/TextMesh Pro/Shaders/TMPro_Surface.cginc.meta
Assets/TextMesh Pro/Sprites.meta
Assets/TextMesh Pro/Sprites/EmojiOne Attribution.txt
Assets/TextMesh Pro/Sprites/EmojiOne Attribution.txt.meta
Assets/TextMesh Pro/Sprites/EmojiOne.json
Assets/TextMesh Pro/Sprites/EmojiOne.json.meta
Assets/TextMesh Pro/Sprites/EmojiOne.png
Assets/TextMesh Pro/Sprites/EmojiOne.png.meta
Assets/_Project/Audio.meta
Assets/_Project/Materials.meta
Assets/_Project/Materials/Building_Ghost_Invalid.mat
Assets/_Project/Materials/Building_Ghost_Invalid.mat.meta
Assets/_Project/Materials/Building_Ghost_Valid.mat
Assets/_Project/Materials/Building_Ghost_Valid.mat.meta
Assets/_Project/Materials/Building_Mat.mat
Assets/_Project/Materials/Building_Mat.mat.meta
Assets/_Project/Materials/Enemy_Mat.mat
Assets/_Project/Materials/Enemy_Mat.mat.meta
Assets/_Project/Materials/Ground_Mat.mat
Assets/_Project/Materials/Ground_Mat.mat.meta
Assets/_Project/Materials/Player_Mat.mat
Assets/_Project/Materials/Player_Mat.mat.meta
Assets/_Project/Prefabs.meta
Assets/_Project/Prefabs/Players/Player.prefab
Assets/_Project/Prefabs/Players/Player.prefab.meta
Assets/_Project/Scenes.meta
Assets/_Project/Scenes/ColonyScene.unity
Assets/_Project/Scenes/ColonyScene.unity.meta
Assets/_Project/Scenes/MainMenu.unity
Assets/_Project/Scenes/MainMenu.unity.meta
Assets/_Project/Scenes/RaidScene.unity
Assets/_Project/Scenes/RaidScene.unity.meta
Assets/_Project/Scripts.meta
Assets/_Project/Scripts/Editor/BuildScript.cs
Assets/_Project/Scripts/Editor/PrefabGenerator.cs
Assets/_Project/Scripts/Editor/SceneGenerator.cs
Assets/_Project/Scripts/Editor/SetupAutomation.cs
Assets/_Project/Scripts/Utilities/DontDestroy.cs
Assets/_Project/Scripts/Utilities/DontDestroy.cs.meta
Assets/_Project/Scripts/Utilities/QuickSetupHelper.cs
Assets/_Project/Scripts/Utilities/QuickSetupHelper.cs.meta
Assets/_Project/Textures.meta
ProjectPlanningDocs/7DayHackathon.md
ProjectPlanningDocs/BuildAutomationPlan.md
ProjectPlanningDocs/Day0.md
ProjectPlanningDocs/DevelopmentOverviewSpaceColonyRPG.md
ProjectSettings/EditorBuildSettings.asset
ProjectSettings/GraphicsSettings.asset
ProjectSettings/ProjectSettings.asset
ProjectSettings/TagManager.asset
build.bat
build.sh

## Statistics  
 .ai-templates/NetworkedClass.template              |   217 +
 .ai-templates/Singleton.template                   |    76 +
 .ai-templates/new_feature.md                       |   112 +
 .ai/architecture.md                                |   187 +
 .ai/conventions.md                                 |   241 +
 .ai/conventions/git_strategy.md                    |   272 +
 .ai/current_sprint.md                              |    84 +
 .ai/debug_context.md                               |    79 +
 .ai/knowledge/common_errors.md                     |   308 +
 .ai/knowledge/git_patterns.md                      |   242 +
 .ai/knowledge/mirror_patterns.md                   |   353 +
 .ai/knowledge/performance_tips.md                  |   443 +
 .ai/knowledge/unity_gotchas.md                     |   430 +
 .ai/review_checklist.md                            |   144 +
 .ai/scripts/analyze_commits.sh                     |   101 +
 .ai/scripts/daily_report.sh                        |    70 +
 .ai/scripts/setup_git_integration.sh               |    68 +
 .ai/start_session.md                               |    48 +
 .ai/workflows/daily_git_workflow.md                |   195 +
 .ai/workflows/git_debugging.md                     |   258 +
 .claudeignore                                      |    11 +-
 .config/dotnet-tools.json                          |    13 +
 Assets/Mirror/Authenticators.meta                  |     8 +
 Assets/Mirror/Authenticators/BasicAuthenticator.cs |   192 +
 .../Authenticators/BasicAuthenticator.cs.meta      |    18 +
 .../Mirror/Authenticators/DeviceAuthenticator.cs   |   129 +
 .../Authenticators/DeviceAuthenticator.cs.meta     |    18 +
 .../Authenticators/Mirror.Authenticators.asmdef    |    16 +
 .../Mirror.Authenticators.asmdef.meta              |    14 +
 .../Mirror/Authenticators/TimeoutAuthenticator.cs  |    70 +
 .../Authenticators/TimeoutAuthenticator.cs.meta    |    18 +
 Assets/Mirror/CompilerSymbols.meta                 |     8 +
 .../CompilerSymbols/Mirror.CompilerSymbols.asmdef  |    14 +
 .../Mirror.CompilerSymbols.asmdef.meta             |    14 +
 .../Mirror/CompilerSymbols/PreprocessorDefine.cs   |    45 +
 .../CompilerSymbols/PreprocessorDefine.cs.meta     |    18 +
 Assets/Mirror/Components.meta                      |     8 +
 Assets/Mirror/Components/AssemblyInfo.cs           |    12 +
 Assets/Mirror/Components/AssemblyInfo.cs.meta      |    18 +
 Assets/Mirror/Components/Discovery.meta            |     8 +
 .../Components/Discovery/NetworkDiscovery.cs       |    93 +
 .../Components/Discovery/NetworkDiscovery.cs.meta  |    18 +
 .../Components/Discovery/NetworkDiscoveryBase.cs   |   473 +
 .../Discovery/NetworkDiscoveryBase.cs.meta         |    18 +
 .../Components/Discovery/NetworkDiscoveryHUD.cs    |   144 +
 .../Discovery/NetworkDiscoveryHUD.cs.meta          |    18 +
 .../Mirror/Components/Discovery/ServerRequest.cs   |     4 +
 .../Components/Discovery/ServerRequest.cs.meta     |    18 +
 .../Mirror/Components/Discovery/ServerResponse.cs  |    18 +
 .../Components/Discovery/ServerResponse.cs.meta    |    18 +
 Assets/Mirror/Components/GUIConsole.cs             |   133 +
 Assets/Mirror/Components/GUIConsole.cs.meta        |    18 +
 Assets/Mirror/Components/InterestManagement.meta   |     8 +
 .../Components/InterestManagement/Distance.meta    |     3 +
 .../Distance/DistanceInterestManagement.cs         |    89 +
 .../Distance/DistanceInterestManagement.cs.meta    |    18 +
 .../DistanceInterestManagementCustomRange.cs       |    15 +
 .../DistanceInterestManagementCustomRange.cs.meta  |    18 +
 .../Components/InterestManagement/Match.meta       |     3 +
 .../Match/MatchInterestManagement.cs               |   164 +
 .../Match/MatchInterestManagement.cs.meta          |    18 +
 .../InterestManagement/Match/NetworkMatch.cs       |    42 +
 .../InterestManagement/Match/NetworkMatch.cs.meta  |    18 +
 .../Components/InterestManagement/Scene.meta       |     3 +
 .../Scene/SceneInterestManagement.cs               |   117 +
 .../Scene/SceneInterestManagement.cs.meta          |    18 +
 .../InterestManagement/SceneDistance.meta          |     8 +
 .../SceneDistanceInterestManagement.cs             |   178 +
 .../SceneDistanceInterestManagement.cs.meta        |    18 +
 .../InterestManagement/SpatialHashing.meta         |     3 +
 .../InterestManagement/SpatialHashing/Grid2D.cs    |   104 +
 .../SpatialHashing/Grid2D.cs.meta                  |    18 +
 .../InterestManagement/SpatialHashing/Grid3D.cs    |   106 +
 .../SpatialHashing/Grid3D.cs.meta                  |    10 +
 .../InterestManagement/SpatialHashing/HexGrid2D.cs |   170 +
 .../SpatialHashing/HexGrid2D.cs.meta               |    18 +
 .../InterestManagement/SpatialHashing/HexGrid3D.cs |   243 +
 .../SpatialHashing/HexGrid3D.cs.meta               |    18 +
 .../HexSpatialHash2DInterestManagement.cs          |   345 +
 .../HexSpatialHash2DInterestManagement.cs.meta     |    18 +
 .../HexSpatialHash3DInterestManagement.cs          |   336 +
 .../HexSpatialHash3DInterestManagement.cs.meta     |    18 +
 .../SpatialHashing3DInterestManagement.cs          |   146 +
 .../SpatialHashing3DInterestManagement.cs.meta     |    18 +
 .../SpatialHashingInterestManagement.cs            |   156 +
 .../SpatialHashingInterestManagement.cs.meta       |    18 +
 .../Mirror/Components/InterestManagement/Team.meta |     8 +
 .../InterestManagement/Team/NetworkTeam.cs         |    39 +
 .../InterestManagement/Team/NetworkTeam.cs.meta    |    18 +
 .../Team/TeamInterestManagement.cs                 |   182 +
 .../Team/TeamInterestManagement.cs.meta            |    18 +
 Assets/Mirror/Components/LagCompensation.meta      |     8 +
 .../Components/LagCompensation/HistoryCollider.cs  |   109 +
 .../LagCompensation/HistoryCollider.cs.meta        |    18 +
 .../Components/LagCompensation/LagCompensator.cs   |   197 +
 .../LagCompensation/LagCompensator.cs.meta         |    18 +
 Assets/Mirror/Components/Mirror.Components.asmdef  |    16 +
 .../Components/Mirror.Components.asmdef.meta       |    14 +
 Assets/Mirror/Components/NetworkAnimator.cs        |   662 +
 Assets/Mirror/Components/NetworkAnimator.cs.meta   |    18 +
 .../Components/NetworkDiagnosticsDebugger.cs       |    31 +
 .../Components/NetworkDiagnosticsDebugger.cs.meta  |    18 +
 Assets/Mirror/Components/NetworkLobbyManager.cs    |    18 +
 .../Mirror/Components/NetworkLobbyManager.cs.meta  |    18 +
 Assets/Mirror/Components/NetworkLobbyPlayer.cs     |    15 +
 .../Mirror/Components/NetworkLobbyPlayer.cs.meta   |    18 +
 Assets/Mirror/Components/NetworkPingDisplay.cs     |    39 +
 .../Mirror/Components/NetworkPingDisplay.cs.meta   |    18 +
 Assets/Mirror/Components/NetworkRigidbody.meta     |     3 +
 .../NetworkRigidbody/NetworkRigidbodyReliable.cs   |   115 +
 .../NetworkRigidbodyReliable.cs.meta               |    18 +
 .../NetworkRigidbody/NetworkRigidbodyReliable2D.cs |   135 +
 .../NetworkRigidbodyReliable2D.cs.meta             |    18 +
 .../NetworkRigidbody/NetworkRigidbodyUnreliable.cs |   115 +
 .../NetworkRigidbodyUnreliable.cs.meta             |    18 +
 .../NetworkRigidbodyUnreliable2D.cs                |   136 +
 .../NetworkRigidbodyUnreliable2D.cs.meta           |    18 +
 Assets/Mirror/Components/NetworkRoomManager.cs     |   683 +
 .../Mirror/Components/NetworkRoomManager.cs.meta   |    18 +
 Assets/Mirror/Components/NetworkRoomPlayer.cs      |   195 +
 Assets/Mirror/Components/NetworkRoomPlayer.cs.meta |    18 +
 Assets/Mirror/Components/NetworkStatistics.cs      |   194 +
 Assets/Mirror/Components/NetworkStatistics.cs.meta |    18 +
 Assets/Mirror/Components/NetworkTransform.meta     |     3 +
 .../NetworkTransform/NetworkTransformBase.cs       |   547 +
 .../NetworkTransform/NetworkTransformBase.cs.meta  |    18 +
 .../NetworkTransform/NetworkTransformHybrid.cs     |   717 +
 .../NetworkTransformHybrid.cs.meta                 |    18 +
 .../NetworkTransform/NetworkTransformReliable.cs   |   448 +
 .../NetworkTransformReliable.cs.meta               |    18 +
 .../NetworkTransform/NetworkTransformUnreliable.cs |   462 +
 .../NetworkTransformUnreliable.cs.meta             |    18 +
 .../NetworkTransform/TransformSnapshot.cs          |    68 +
 .../NetworkTransform/TransformSnapshot.cs.meta     |    18 +
 .../NetworkTransform/TransformSyncData.cs          |   156 +
 .../NetworkTransform/TransformSyncData.cs.meta     |    18 +
 Assets/Mirror/Components/PredictedRigidbody.meta   |     3 +
 .../PredictedRigidbody/LocalGhostMaterial.mat      |    85 +
 .../PredictedRigidbody/LocalGhostMaterial.mat.meta |    15 +
 .../PredictedRigidbody/PredictedRigidbody.cs       |  1021 +
 .../PredictedRigidbody/PredictedRigidbody.cs.meta  |    22 +
 .../PredictedRigidbodyPhysicsGhost.cs              |    15 +
 .../PredictedRigidbodyPhysicsGhost.cs.meta         |    18 +
 .../PredictedRigidbodyRemoteGhost.cs               |     1 +
 .../PredictedRigidbodyRemoteGhost.cs.meta          |    18 +
 .../PredictedRigidbody/PredictedSyncData.cs        |    54 +
 .../PredictedRigidbody/PredictedSyncData.cs.meta   |    10 +
 .../PredictedRigidbody/PredictionUtils.cs          |   430 +
 .../PredictedRigidbody/PredictionUtils.cs.meta     |    18 +
 .../PredictedRigidbody/RemoteGhostMaterial.mat     |    85 +
 .../RemoteGhostMaterial.mat.meta                   |    15 +
 .../PredictedRigidbody/RigidbodyState.cs           |    60 +
 .../PredictedRigidbody/RigidbodyState.cs.meta      |    18 +
 Assets/Mirror/Components/Profiling.meta            |     3 +
 Assets/Mirror/Components/Profiling/BaseUIGraph.cs  |   217 +
 .../Components/Profiling/BaseUIGraph.cs.meta       |    21 +
 .../Components/Profiling/FpsMinMaxAvgGraph.cs      |    40 +
 .../Components/Profiling/FpsMinMaxAvgGraph.cs.meta |    18 +
 Assets/Mirror/Components/Profiling/LineGraph.mat   |    89 +
 .../Mirror/Components/Profiling/LineGraph.mat.meta |    15 +
 .../Components/Profiling/NetworkBandwidthGraph.cs  |    85 +
 .../Profiling/NetworkBandwidthGraph.cs.meta        |    18 +
 .../Components/Profiling/NetworkGraphLines.shader  |   178 +
 .../Profiling/NetworkGraphLines.shader.meta        |    10 +
 .../Profiling/NetworkGraphStacked.shader           |   138 +
 .../Profiling/NetworkGraphStacked.shader.meta      |    10 +
 .../Components/Profiling/NetworkPingGraph.cs       |    34 +
 .../Components/Profiling/NetworkPingGraph.cs.meta  |    18 +
 .../Components/Profiling/NetworkRuntimeProfiler.cs |   315 +
 .../Profiling/NetworkRuntimeProfiler.cs.meta       |    18 +
 Assets/Mirror/Components/Profiling/Prefabs.meta    |     8 +
 .../Profiling/Prefabs/BandwidthGraph.prefab        |  1776 ++
 .../Profiling/Prefabs/BandwidthGraph.prefab.meta   |    14 +
 .../Profiling/Prefabs/FPSMinMaxAvg.prefab          |  1976 ++
 .../Profiling/Prefabs/FPSMinMaxAvg.prefab.meta     |    14 +
 .../Profiling/Prefabs/GraphCanvas.prefab           |   765 +
 .../Profiling/Prefabs/GraphCanvas.prefab.meta      |    14 +
 .../Profiling/Prefabs/NetworkGraph.prefab          |  2888 +++
 .../Profiling/Prefabs/NetworkGraph.prefab.meta     |    14 +
 .../Components/Profiling/Prefabs/PingGraph.prefab  |  1776 ++
 .../Profiling/Prefabs/PingGraph.prefab.meta        |    14 +
 .../Mirror/Components/Profiling/StackedGraph.mat   |    88 +
 .../Components/Profiling/StackedGraph.mat.meta     |    15 +
 Assets/Mirror/Components/Profiling/ToggleHotkey.cs |    15 +
 .../Components/Profiling/ToggleHotkey.cs.meta      |    18 +
 Assets/Mirror/Components/RemoteStatistics.cs       |   441 +
 Assets/Mirror/Components/RemoteStatistics.cs.meta  |    18 +
 Assets/Mirror/Core.meta                            |     8 +
 Assets/Mirror/Core/AssemblyInfo.cs                 |    13 +
 Assets/Mirror/Core/AssemblyInfo.cs.meta            |    18 +
 Assets/Mirror/Core/Attributes.cs                   |   101 +
 Assets/Mirror/Core/Attributes.cs.meta              |    18 +
 Assets/Mirror/Core/Batching.meta                   |     8 +
 Assets/Mirror/Core/Batching/Batcher.cs             |   206 +
 Assets/Mirror/Core/Batching/Batcher.cs.meta        |    18 +
 Assets/Mirror/Core/Batching/Unbatcher.cs           |   129 +
 Assets/Mirror/Core/Batching/Unbatcher.cs.meta      |    18 +
 Assets/Mirror/Core/ConnectionQuality.cs            |    74 +
 Assets/Mirror/Core/ConnectionQuality.cs.meta       |    18 +
 Assets/Mirror/Core/HostMode.cs                     |    44 +
 Assets/Mirror/Core/HostMode.cs.meta                |    18 +
 Assets/Mirror/Core/InterestManagement.cs           |   146 +
 Assets/Mirror/Core/InterestManagement.cs.meta      |    18 +
 Assets/Mirror/Core/InterestManagementBase.cs       |   103 +
 Assets/Mirror/Core/InterestManagementBase.cs.meta  |    18 +
 Assets/Mirror/Core/LagCompensation.meta            |     3 +
 Assets/Mirror/Core/LagCompensation/Capture.cs      |    13 +
 Assets/Mirror/Core/LagCompensation/Capture.cs.meta |    18 +
 .../Mirror/Core/LagCompensation/HistoryBounds.cs   |   139 +
 .../Core/LagCompensation/HistoryBounds.cs.meta     |    18 +
 .../Mirror/Core/LagCompensation/LagCompensation.cs |   144 +
 .../Core/LagCompensation/LagCompensation.cs.meta   |    18 +
 .../LagCompensation/LagCompensationSettings.cs     |    19 +
 .../LagCompensationSettings.cs.meta                |    18 +
 Assets/Mirror/Core/LagCompensation/MinMaxBounds.cs |    73 +
 .../Core/LagCompensation/MinMaxBounds.cs.meta      |    18 +
 Assets/Mirror/Core/LocalConnectionToClient.cs      |    80 +
 Assets/Mirror/Core/LocalConnectionToClient.cs.meta |    18 +
 Assets/Mirror/Core/LocalConnectionToServer.cs      |   117 +
 Assets/Mirror/Core/LocalConnectionToServer.cs.meta |    18 +
 Assets/Mirror/Core/Messages.cs                     |   186 +
 Assets/Mirror/Core/Messages.cs.meta                |    18 +
 Assets/Mirror/Core/Mirror.asmdef                   |    16 +
 Assets/Mirror/Core/Mirror.asmdef.meta              |    14 +
 Assets/Mirror/Core/NetworkAuthenticator.cs         |    84 +
 Assets/Mirror/Core/NetworkAuthenticator.cs.meta    |    18 +
 Assets/Mirror/Core/NetworkBehaviour.cs             |  1386 ++
 Assets/Mirror/Core/NetworkBehaviour.cs.meta        |    18 +
 Assets/Mirror/Core/NetworkBehaviourHybrid.cs       |   483 +
 Assets/Mirror/Core/NetworkBehaviourHybrid.cs.meta  |    18 +
 Assets/Mirror/Core/NetworkBehaviourSyncVar.cs      |    33 +
 Assets/Mirror/Core/NetworkBehaviourSyncVar.cs.meta |    18 +
 Assets/Mirror/Core/NetworkClient.cs                |  1885 ++
 Assets/Mirror/Core/NetworkClient.cs.meta           |    18 +
 .../Mirror/Core/NetworkClient_TimeInterpolation.cs |   151 +
 .../Core/NetworkClient_TimeInterpolation.cs.meta   |    18 +
 Assets/Mirror/Core/NetworkConnection.cs            |   207 +
 Assets/Mirror/Core/NetworkConnection.cs.meta       |    18 +
 Assets/Mirror/Core/NetworkConnectionToClient.cs    |   230 +
 .../Mirror/Core/NetworkConnectionToClient.cs.meta  |    18 +
 Assets/Mirror/Core/NetworkConnectionToServer.cs    |    24 +
 .../Mirror/Core/NetworkConnectionToServer.cs.meta  |    18 +
 Assets/Mirror/Core/NetworkDiagnostics.cs           |    63 +
 Assets/Mirror/Core/NetworkDiagnostics.cs.meta      |    18 +
 Assets/Mirror/Core/NetworkIdentity.cs              |  1411 ++
 Assets/Mirror/Core/NetworkIdentity.cs.meta         |    18 +
 Assets/Mirror/Core/NetworkLoop.cs                  |   211 +
 Assets/Mirror/Core/NetworkLoop.cs.meta             |    18 +
 Assets/Mirror/Core/NetworkManager.cs               |  1452 ++
 Assets/Mirror/Core/NetworkManager.cs.meta          |    18 +
 Assets/Mirror/Core/NetworkManagerHUD.cs            |   162 +
 Assets/Mirror/Core/NetworkManagerHUD.cs.meta       |    18 +
 Assets/Mirror/Core/NetworkMessage.cs               |     4 +
 Assets/Mirror/Core/NetworkMessage.cs.meta          |    18 +
 Assets/Mirror/Core/NetworkMessages.cs              |   210 +
 Assets/Mirror/Core/NetworkMessages.cs.meta         |    18 +
 Assets/Mirror/Core/NetworkReader.cs                |   249 +
 Assets/Mirror/Core/NetworkReader.cs.meta           |    18 +
 Assets/Mirror/Core/NetworkReaderExtensions.cs      |   420 +
 Assets/Mirror/Core/NetworkReaderExtensions.cs.meta |    18 +
 Assets/Mirror/Core/NetworkReaderPool.cs            |    48 +
 Assets/Mirror/Core/NetworkReaderPool.cs.meta       |    18 +
 Assets/Mirror/Core/NetworkReaderPooled.cs          |    12 +
 Assets/Mirror/Core/NetworkReaderPooled.cs.meta     |    18 +
 Assets/Mirror/Core/NetworkServer.cs                |  2111 ++
 Assets/Mirror/Core/NetworkServer.cs.meta           |    18 +
 Assets/Mirror/Core/NetworkStartPosition.cs         |    21 +
 Assets/Mirror/Core/NetworkStartPosition.cs.meta    |    18 +
 Assets/Mirror/Core/NetworkTime.cs                  |   243 +
 Assets/Mirror/Core/NetworkTime.cs.meta             |    18 +
 Assets/Mirror/Core/NetworkWriter.cs                |   249 +
 Assets/Mirror/Core/NetworkWriter.cs.meta           |    18 +
 Assets/Mirror/Core/NetworkWriterExtensions.cs      |   471 +
 Assets/Mirror/Core/NetworkWriterExtensions.cs.meta |    18 +
 Assets/Mirror/Core/NetworkWriterPool.cs            |    40 +
 Assets/Mirror/Core/NetworkWriterPool.cs.meta       |    18 +
 Assets/Mirror/Core/NetworkWriterPooled.cs          |    10 +
 Assets/Mirror/Core/NetworkWriterPooled.cs.meta     |    18 +
 Assets/Mirror/Core/PortTransport.cs                |    13 +
 Assets/Mirror/Core/PortTransport.cs.meta           |    18 +
 Assets/Mirror/Core/Prediction.meta                 |     3 +
 Assets/Mirror/Core/Prediction/Prediction.cs        |   195 +
 Assets/Mirror/Core/Prediction/Prediction.cs.meta   |    18 +
 Assets/Mirror/Core/RemoteCalls.cs                  |   151 +
 Assets/Mirror/Core/RemoteCalls.cs.meta             |    18 +
 Assets/Mirror/Core/SnapshotInterpolation.meta      |     8 +
 .../Mirror/Core/SnapshotInterpolation/Snapshot.cs  |    17 +
 .../Core/SnapshotInterpolation/Snapshot.cs.meta    |    18 +
 .../SnapshotInterpolation/SnapshotInterpolation.cs |   390 +
 .../SnapshotInterpolation.cs.meta                  |    18 +
 .../SnapshotInterpolationSettings.cs               |    70 +
 .../SnapshotInterpolationSettings.cs.meta          |    10 +
 .../Core/SnapshotInterpolation/TimeSnapshot.cs     |    15 +
 .../SnapshotInterpolation/TimeSnapshot.cs.meta     |    18 +
 Assets/Mirror/Core/SyncDictionary.cs               |   358 +
 Assets/Mirror/Core/SyncDictionary.cs.meta          |    18 +
 Assets/Mirror/Core/SyncList.cs                     |   473 +
 Assets/Mirror/Core/SyncList.cs.meta                |    18 +
 Assets/Mirror/Core/SyncObject.cs                   |    53 +
 Assets/Mirror/Core/SyncObject.cs.meta              |    18 +
 Assets/Mirror/Core/SyncSet.cs                      |   377 +
 Assets/Mirror/Core/SyncSet.cs.meta                 |    18 +
 Assets/Mirror/Core/Threading.meta                  |     8 +
 .../Core/Threading/ConcurrentNetworkWriterPool.cs  |    45 +
 .../Threading/ConcurrentNetworkWriterPool.cs.meta  |    18 +
 .../Threading/ConcurrentNetworkWriterPooled.cs     |    10 +
 .../ConcurrentNetworkWriterPooled.cs.meta          |    10 +
 Assets/Mirror/Core/Threading/ConcurrentPool.cs     |    44 +
 .../Mirror/Core/Threading/ConcurrentPool.cs.meta   |    18 +
 Assets/Mirror/Core/Threading/ThreadLog.cs          |   112 +
 Assets/Mirror/Core/Threading/ThreadLog.cs.meta     |    18 +
 Assets/Mirror/Core/Threading/WorkerThread.cs       |   169 +
 Assets/Mirror/Core/Threading/WorkerThread.cs.meta  |    18 +
 Assets/Mirror/Core/Tools.meta                      |     3 +
 Assets/Mirror/Core/Tools/AccurateInterval.cs       |    86 +
 Assets/Mirror/Core/Tools/AccurateInterval.cs.meta  |    18 +
 Assets/Mirror/Core/Tools/Compression.cs            |   596 +
 Assets/Mirror/Core/Tools/Compression.cs.meta       |    18 +
 Assets/Mirror/Core/Tools/DeltaCompression.cs       |    58 +
 Assets/Mirror/Core/Tools/DeltaCompression.cs.meta  |    18 +
 .../Mirror/Core/Tools/ExponentialMovingAverage.cs  |    53 +
 .../Core/Tools/ExponentialMovingAverage.cs.meta    |    18 +
 Assets/Mirror/Core/Tools/Extensions.cs             |   145 +
 Assets/Mirror/Core/Tools/Extensions.cs.meta        |    18 +
 Assets/Mirror/Core/Tools/Half.cs                   |   773 +
 Assets/Mirror/Core/Tools/Half.cs.meta              |    10 +
 Assets/Mirror/Core/Tools/Mathd.cs                  |    32 +
 Assets/Mirror/Core/Tools/Mathd.cs.meta             |    18 +
 Assets/Mirror/Core/Tools/Pool.cs                   |    48 +
 Assets/Mirror/Core/Tools/Pool.cs.meta              |    18 +
 Assets/Mirror/Core/Tools/Readme.txt                |     1 +
 Assets/Mirror/Core/Tools/Readme.txt.meta           |    10 +
 Assets/Mirror/Core/Tools/TimeSample.cs             |    61 +
 Assets/Mirror/Core/Tools/TimeSample.cs.meta        |    18 +
 Assets/Mirror/Core/Tools/Utils.cs                  |   222 +
 Assets/Mirror/Core/Tools/Utils.cs.meta             |    18 +
 Assets/Mirror/Core/Tools/Vector3Long.cs            |   125 +
 Assets/Mirror/Core/Tools/Vector3Long.cs.meta       |    18 +
 Assets/Mirror/Core/Tools/Vector4Long.cs            |   126 +
 Assets/Mirror/Core/Tools/Vector4Long.cs.meta       |    10 +
 Assets/Mirror/Core/Transport.cs                    |   210 +
 Assets/Mirror/Core/Transport.cs.meta               |    18 +
 Assets/Mirror/Core/TransportError.cs               |    17 +
 Assets/Mirror/Core/TransportError.cs.meta          |    18 +
 Assets/Mirror/Core/WeaverFuse.cs                   |    22 +
 Assets/Mirror/Core/WeaverFuse.cs.meta              |    18 +
 Assets/Mirror/Editor.meta                          |     8 +
 Assets/Mirror/Editor/AndroidManifestHelper.cs      |   116 +
 Assets/Mirror/Editor/AndroidManifestHelper.cs.meta |    18 +
 Assets/Mirror/Editor/EditorHelper.cs               |    41 +
 Assets/Mirror/Editor/EditorHelper.cs.meta          |    18 +
 Assets/Mirror/Editor/Icon.meta                     |     8 +
 Assets/Mirror/Editor/Icon/MirrorIcon.png           |   Bin 0 -> 138247 bytes
 Assets/Mirror/Editor/Icon/MirrorIcon.png.meta      |   117 +
 Assets/Mirror/Editor/InspectorHelper.cs            |    77 +
 Assets/Mirror/Editor/InspectorHelper.cs.meta       |    18 +
 Assets/Mirror/Editor/LagCompensatorInspector.cs    |    14 +
 .../Mirror/Editor/LagCompensatorInspector.cs.meta  |    18 +
 Assets/Mirror/Editor/Mirror.Editor.asmdef          |    20 +
 Assets/Mirror/Editor/Mirror.Editor.asmdef.meta     |    14 +
 Assets/Mirror/Editor/NetworkBehaviourInspector.cs  |   104 +
 .../Editor/NetworkBehaviourInspector.cs.meta       |    18 +
 Assets/Mirror/Editor/NetworkInformationPreview.cs  |   307 +
 .../Editor/NetworkInformationPreview.cs.meta       |    18 +
 Assets/Mirror/Editor/NetworkManagerEditor.cs       |   203 +
 Assets/Mirror/Editor/NetworkManagerEditor.cs.meta  |    18 +
 Assets/Mirror/Editor/NetworkScenePostProcess.cs    |   107 +
 .../Mirror/Editor/NetworkScenePostProcess.cs.meta  |    18 +
 Assets/Mirror/Editor/ReadOnlyDrawer.cs             |    19 +
 Assets/Mirror/Editor/ReadOnlyDrawer.cs.meta        |    18 +
 Assets/Mirror/Editor/SceneDrawer.cs                |    47 +
 Assets/Mirror/Editor/SceneDrawer.cs.meta           |    18 +
 .../Mirror/Editor/SyncObjectCollectionsDrawer.cs   |    89 +
 .../Editor/SyncObjectCollectionsDrawer.cs.meta     |    10 +
 Assets/Mirror/Editor/SyncVarAttributeDrawer.cs     |    28 +
 .../Mirror/Editor/SyncVarAttributeDrawer.cs.meta   |    18 +
 Assets/Mirror/Editor/Weaver.meta                   |     8 +
 Assets/Mirror/Editor/Weaver/AssemblyInfo.cs        |     3 +
 Assets/Mirror/Editor/Weaver/AssemblyInfo.cs.meta   |    18 +
 Assets/Mirror/Editor/Weaver/EntryPoint.meta        |     3 +
 .../Weaver/EntryPoint/CompilationFinishedHook.cs   |   188 +
 .../EntryPoint/CompilationFinishedHook.cs.meta     |    18 +
 .../Weaver/EntryPoint/CompilationFinishedLogger.cs |    31 +
 .../EntryPoint/CompilationFinishedLogger.cs.meta   |    10 +
 .../Editor/Weaver/EntryPoint/EnterPlayModeHook.cs  |    44 +
 .../Weaver/EntryPoint/EnterPlayModeHook.cs.meta    |    10 +
 .../Editor/Weaver/EntryPointILPostProcessor.meta   |     3 +
 .../CompiledAssemblyFromFile.cs                    |    31 +
 .../CompiledAssemblyFromFile.cs.meta               |    10 +
 .../ILPostProcessorAssemblyResolver.cs             |   205 +
 .../ILPostProcessorAssemblyResolver.cs.meta        |    10 +
 .../ILPostProcessorFromFile.cs                     |    53 +
 .../ILPostProcessorFromFile.cs.meta                |    10 +
 .../ILPostProcessorHook.cs                         |   143 +
 .../ILPostProcessorHook.cs.meta                    |    10 +
 .../ILPostProcessorLogger.cs                       |    68 +
 .../ILPostProcessorLogger.cs.meta                  |    10 +
 .../ILPostProcessorReflectionImporter.cs           |    36 +
 .../ILPostProcessorReflectionImporter.cs.meta      |    10 +
 .../ILPostProcessorReflectionImporterProvider.cs   |    16 +
 ...PostProcessorReflectionImporterProvider.cs.meta |    10 +
 Assets/Mirror/Editor/Weaver/Extensions.cs          |   359 +
 Assets/Mirror/Editor/Weaver/Extensions.cs.meta     |    18 +
 Assets/Mirror/Editor/Weaver/Helpers.cs             |    26 +
 Assets/Mirror/Editor/Weaver/Helpers.cs.meta        |    18 +
 Assets/Mirror/Editor/Weaver/Logger.cs              |    13 +
 Assets/Mirror/Editor/Weaver/Logger.cs.meta         |    18 +
 Assets/Mirror/Editor/Weaver/Processors.meta        |     8 +
 .../Editor/Weaver/Processors/CommandProcessor.cs   |   130 +
 .../Weaver/Processors/CommandProcessor.cs.meta     |    18 +
 .../Editor/Weaver/Processors/MethodProcessor.cs    |   139 +
 .../Weaver/Processors/MethodProcessor.cs.meta      |    18 +
 .../Weaver/Processors/MonoBehaviourProcessor.cs    |    56 +
 .../Processors/MonoBehaviourProcessor.cs.meta      |    18 +
 .../Weaver/Processors/NetworkBehaviourProcessor.cs |  1055 +
 .../Processors/NetworkBehaviourProcessor.cs.meta   |    18 +
 .../Weaver/Processors/ReaderWriterProcessor.cs     |   260 +
 .../Processors/ReaderWriterProcessor.cs.meta       |    18 +
 .../Editor/Weaver/Processors/RpcProcessor.cs       |   104 +
 .../Editor/Weaver/Processors/RpcProcessor.cs.meta  |    18 +
 .../Processors/ServerClientAttributeProcessor.cs   |   163 +
 .../ServerClientAttributeProcessor.cs.meta         |    18 +
 .../Weaver/Processors/SyncObjectInitializer.cs     |    39 +
 .../Processors/SyncObjectInitializer.cs.meta       |    18 +
 .../Weaver/Processors/SyncObjectProcessor.cs       |    90 +
 .../Weaver/Processors/SyncObjectProcessor.cs.meta  |    18 +
 .../Processors/SyncVarAttributeAccessReplacer.cs   |   206 +
 .../SyncVarAttributeAccessReplacer.cs.meta         |    18 +
 .../Weaver/Processors/SyncVarAttributeProcessor.cs |   515 +
 .../Processors/SyncVarAttributeProcessor.cs.meta   |    18 +
 .../Editor/Weaver/Processors/TargetRpcProcessor.cs |   159 +
 .../Weaver/Processors/TargetRpcProcessor.cs.meta   |    18 +
 Assets/Mirror/Editor/Weaver/Readers.cs             |   404 +
 Assets/Mirror/Editor/Weaver/Readers.cs.meta        |    18 +
 Assets/Mirror/Editor/Weaver/Resolvers.cs           |   126 +
 Assets/Mirror/Editor/Weaver/Resolvers.cs.meta      |    18 +
 Assets/Mirror/Editor/Weaver/SyncVarAccessLists.cs  |    32 +
 .../Editor/Weaver/SyncVarAccessLists.cs.meta       |    10 +
 .../Mirror/Editor/Weaver/TypeReferenceComparer.cs  |    15 +
 .../Editor/Weaver/TypeReferenceComparer.cs.meta    |    18 +
 .../Editor/Weaver/Unity.Mirror.CodeGen.asmdef      |    21 +
 .../Editor/Weaver/Unity.Mirror.CodeGen.asmdef.meta |    14 +
 Assets/Mirror/Editor/Weaver/Weaver.cs              |   267 +
 Assets/Mirror/Editor/Weaver/Weaver.cs.meta         |    18 +
 Assets/Mirror/Editor/Weaver/WeaverExceptions.cs    |    26 +
 .../Mirror/Editor/Weaver/WeaverExceptions.cs.meta  |    18 +
 Assets/Mirror/Editor/Weaver/WeaverTypes.cs         |   171 +
 Assets/Mirror/Editor/Weaver/WeaverTypes.cs.meta    |    10 +
 Assets/Mirror/Editor/Weaver/Writers.cs             |   360 +
 Assets/Mirror/Editor/Weaver/Writers.cs.meta        |    18 +
 Assets/Mirror/Editor/Welcome.cs                    |    23 +
 Assets/Mirror/Editor/Welcome.cs.meta               |    18 +
 Assets/Mirror/Examples.meta                        |     8 +
 Assets/Mirror/Examples/AdditiveLevels.meta         |     8 +
 .../Mirror/Examples/AdditiveLevels/Materials.meta  |     8 +
 .../AdditiveLevels/Materials/CubeSphere.mat        |    77 +
 .../AdditiveLevels/Materials/CubeSphere.mat.meta   |    15 +
 .../Examples/AdditiveLevels/Materials/Ground.mat   |    77 +
 .../AdditiveLevels/Materials/Ground.mat.meta       |    15 +
 .../Examples/AdditiveLevels/Materials/Player.mat   |    77 +
 .../AdditiveLevels/Materials/Player.mat.meta       |    15 +
 .../Examples/AdditiveLevels/Materials/Portal.mat   |    78 +
 .../AdditiveLevels/Materials/Portal.mat.meta       |    15 +
 .../Examples/AdditiveLevels/Materials/Skybox.mat   |   104 +
 .../AdditiveLevels/Materials/Skybox.mat.meta       |    16 +
 .../AdditiveLevels/Materials/StartPoint.mat        |    78 +
 .../AdditiveLevels/Materials/StartPoint.mat.meta   |    15 +
 Assets/Mirror/Examples/AdditiveLevels/Prefabs.meta |     8 +
 .../Examples/AdditiveLevels/Prefabs/Cube.prefab    |   132 +
 .../AdditiveLevels/Prefabs/Cube.prefab.meta        |    14 +
 .../Examples/AdditiveLevels/Prefabs/Plane.prefab   |   152 +
 .../AdditiveLevels/Prefabs/Plane.prefab.meta       |    14 +
 .../AdditiveLevels/Prefabs/PlayerReliable.prefab   |   385 +
 .../Prefabs/PlayerReliable.prefab.meta             |    14 +
 .../AdditiveLevels/Prefabs/PlayerUnreliable.prefab |   385 +
 .../Prefabs/PlayerUnreliable.prefab.meta           |    14 +
 .../Examples/AdditiveLevels/Prefabs/Portal.prefab  |   246 +
 .../AdditiveLevels/Prefabs/Portal.prefab.meta      |    14 +
 .../Examples/AdditiveLevels/Prefabs/Sphere.prefab  |   132 +
 .../AdditiveLevels/Prefabs/Sphere.prefab.meta      |    14 +
 .../AdditiveLevels/Prefabs/StartPoint.prefab       |    85 +
 .../AdditiveLevels/Prefabs/StartPoint.prefab.meta  |    14 +
 Assets/Mirror/Examples/AdditiveLevels/ReadMe.txt   |     1 +
 .../Mirror/Examples/AdditiveLevels/ReadMe.txt.meta |    14 +
 Assets/Mirror/Examples/AdditiveLevels/Scenes.meta  |     8 +
 .../Scenes/MirrorAdditiveLevelsOffline.unity       |   510 +
 .../Scenes/MirrorAdditiveLevelsOffline.unity.meta  |    14 +
 .../Scenes/MirrorAdditiveLevelsOnline.meta         |     8 +
 .../Scenes/MirrorAdditiveLevelsOnline.unity        |   816 +
 .../Scenes/MirrorAdditiveLevelsOnline.unity.meta   |    14 +
 .../MirrorAdditiveLevelsOnline/LightingData.asset  |   Bin 0 -> 19648 bytes
 .../LightingData.asset.meta                        |    15 +
 .../ReflectionProbe-0.exr                          |   Bin 0 -> 140188 bytes
 .../ReflectionProbe-0.exr.meta                     |    99 +
 .../Scenes/MirrorAdditiveLevelsSubLevel1.unity     |  1042 +
 .../MirrorAdditiveLevelsSubLevel1.unity.meta       |    14 +
 .../Scenes/MirrorAdditiveLevelsSubLevel2.unity     |   841 +
 .../MirrorAdditiveLevelsSubLevel2.unity.meta       |    14 +
 Assets/Mirror/Examples/AdditiveLevels/Scripts.meta |     8 +
 .../Scripts/AdditiveLevelsNetworkManager.cs        |   187 +
 .../Scripts/AdditiveLevelsNetworkManager.cs.meta   |    18 +
 .../Examples/AdditiveLevels/Scripts/FadeInOut.cs   |    77 +
 .../AdditiveLevels/Scripts/FadeInOut.cs.meta       |    18 +
 .../AdditiveLevels/Scripts/LookAtMainCamera.cs     |    21 +
 .../Scripts/LookAtMainCamera.cs.meta               |    18 +
 .../Examples/AdditiveLevels/Scripts/Portal.cs      |   104 +
 .../Examples/AdditiveLevels/Scripts/Portal.cs.meta |    18 +
 .../Mirror/Examples/AdditiveLevels/Textures.meta   |     9 +
 .../Examples/AdditiveLevels/Textures/Back_Tex.jpeg |   Bin 0 -> 68766 bytes
 .../AdditiveLevels/Textures/Back_Tex.jpeg.meta     |    99 +
 .../Examples/AdditiveLevels/Textures/Down_Tex.jpeg |   Bin 0 -> 75605 bytes
 .../AdditiveLevels/Textures/Down_Tex.jpeg.meta     |    99 +
 .../AdditiveLevels/Textures/Front_Tex.jpeg         |   Bin 0 -> 72964 bytes
 .../AdditiveLevels/Textures/Front_Tex.jpeg.meta    |    99 +
 .../Examples/AdditiveLevels/Textures/Left_Tex.jpeg |   Bin 0 -> 68026 bytes
 .../AdditiveLevels/Textures/Left_Tex.jpeg.meta     |    99 +
 .../AdditiveLevels/Textures/Right_Tex.jpeg         |   Bin 0 -> 70199 bytes
 .../AdditiveLevels/Textures/Right_Tex.jpeg.meta    |    99 +
 .../Examples/AdditiveLevels/Textures/Up_Tex.jpeg   |   Bin 0 -> 69705 bytes
 .../AdditiveLevels/Textures/Up_Tex.jpeg.meta       |    99 +
 Assets/Mirror/Examples/AdditiveScenes.meta         |     8 +
 .../Mirror/Examples/AdditiveScenes/Materials.meta  |     8 +
 .../Examples/AdditiveScenes/Materials/Capsule.mat  |    77 +
 .../AdditiveScenes/Materials/Capsule.mat.meta      |    15 +
 .../Examples/AdditiveScenes/Materials/Cube.mat     |    77 +
 .../AdditiveScenes/Materials/Cube.mat.meta         |    15 +
 .../Examples/AdditiveScenes/Materials/Cylinder.mat |    77 +
 .../AdditiveScenes/Materials/Cylinder.mat.meta     |    15 +
 .../Examples/AdditiveScenes/Materials/Player.mat   |    77 +
 .../AdditiveScenes/Materials/Player.mat.meta       |    15 +
 .../Examples/AdditiveScenes/Materials/Quad.mat     |    77 +
 .../AdditiveScenes/Materials/Quad.mat.meta         |    15 +
 .../Examples/AdditiveScenes/Materials/Shelter.mat  |    77 +
 .../AdditiveScenes/Materials/Shelter.mat.meta      |    15 +
 .../Examples/AdditiveScenes/Materials/Sphere.mat   |    77 +
 .../AdditiveScenes/Materials/Sphere.mat.meta       |    15 +
 .../Examples/AdditiveScenes/Materials/Zone.mat     |    78 +
 .../AdditiveScenes/Materials/Zone.mat.meta         |    15 +
 Assets/Mirror/Examples/AdditiveScenes/Prefabs.meta |     8 +
 .../Examples/AdditiveScenes/Prefabs/Capsule.prefab |   145 +
 .../AdditiveScenes/Prefabs/Capsule.prefab.meta     |    14 +
 .../Examples/AdditiveScenes/Prefabs/Cube.prefab    |   144 +
 .../AdditiveScenes/Prefabs/Cube.prefab.meta        |    14 +
 .../AdditiveScenes/Prefabs/Cylinder.prefab         |   145 +
 .../AdditiveScenes/Prefabs/Cylinder.prefab.meta    |    14 +
 .../AdditiveScenes/Prefabs/PlayerReliable.prefab   |   402 +
 .../Prefabs/PlayerReliable.prefab.meta             |    14 +
 .../AdditiveScenes/Prefabs/PlayerUnreliable.prefab |   402 +
 .../Prefabs/PlayerUnreliable.prefab.meta           |    14 +
 .../Examples/AdditiveScenes/Prefabs/Sphere.prefab  |   144 +
 .../AdditiveScenes/Prefabs/Sphere.prefab.meta      |    14 +
 .../Examples/AdditiveScenes/Prefabs/Tank.prefab    |   180 +
 .../AdditiveScenes/Prefabs/Tank.prefab.meta        |    14 +
 .../Examples/AdditiveScenes/Prefabs/Zone.prefab    |    60 +
 .../AdditiveScenes/Prefabs/Zone.prefab.meta        |    14 +
 Assets/Mirror/Examples/AdditiveScenes/README.md    |    24 +
 .../Mirror/Examples/AdditiveScenes/README.md.meta  |    14 +
 Assets/Mirror/Examples/AdditiveScenes/Scenes.meta  |     8 +
 .../Scenes/MirrorAdditiveScenesMain.meta           |     8 +
 .../Scenes/MirrorAdditiveScenesMain.unity          |  2167 ++
 .../Scenes/MirrorAdditiveScenesMain.unity.meta     |    14 +
 .../MirrorAdditiveScenesMain/LightingData.asset    |   Bin 0 -> 19240 bytes
 .../LightingData.asset.meta                        |    15 +
 .../MirrorAdditiveScenesMain/ReflectionProbe-0.exr |   Bin 0 -> 110488 bytes
 .../ReflectionProbe-0.exr.meta                     |    99 +
 .../Scenes/MirrorAdditiveScenesSubScene.unity      |   840 +
 .../Scenes/MirrorAdditiveScenesSubScene.unity.meta |    14 +
 Assets/Mirror/Examples/AdditiveScenes/Scripts.meta |     8 +
 .../Scripts/AdditiveNetworkManager.cs              |    58 +
 .../Scripts/AdditiveNetworkManager.cs.meta         |    18 +
 .../Scripts/ShootingTankBehaviour.cs               |    59 +
 .../Scripts/ShootingTankBehaviour.cs.meta          |    18 +
 .../Examples/AdditiveScenes/Scripts/ZoneHandler.cs |    42 +
 .../AdditiveScenes/Scripts/ZoneHandler.cs.meta     |    18 +
 .../Mirror/Examples/AutoLANClientController.meta   |     8 +
 .../MirrorAutoLANClientController.unity            |  3214 +++
 .../MirrorAutoLANClientController.unity.meta       |    14 +
 .../Examples/AutoLANClientController/Prefabs.meta  |     8 +
 .../Prefabs/PlayerController.prefab                |    50 +
 .../Prefabs/PlayerController.prefab.meta           |    14 +
 .../Examples/AutoLANClientController/Scripts.meta  |     8 +
 .../Scripts/AutoLANNetworkDiscovery.cs             |   105 +
 .../Scripts/AutoLANNetworkDiscovery.cs.meta        |    18 +
 .../Scripts/AutoLANNetworkManager.cs               |   336 +
 .../Scripts/AutoLANNetworkManager.cs.meta          |    18 +
 .../AutoLANClientController/Scripts/CanvasHUD.cs   |   204 +
 .../Scripts/CanvasHUD.cs.meta                      |    18 +
 .../Scripts/NetworkSceneScript.cs                  |    48 +
 .../Scripts/NetworkSceneScript.cs.meta             |    18 +
 Assets/Mirror/Examples/Basic.meta                  |     8 +
 Assets/Mirror/Examples/Basic/Prefabs.meta          |     8 +
 Assets/Mirror/Examples/Basic/Prefabs/Player.prefab |    73 +
 .../Examples/Basic/Prefabs/Player.prefab.meta      |    14 +
 .../Mirror/Examples/Basic/Prefabs/PlayerUI.prefab  |   250 +
 .../Examples/Basic/Prefabs/PlayerUI.prefab.meta    |    14 +
 Assets/Mirror/Examples/Basic/README.md             |    16 +
 Assets/Mirror/Examples/Basic/README.md.meta        |    14 +
 Assets/Mirror/Examples/Basic/Scenes.meta           |     8 +
 .../Mirror/Examples/Basic/Scenes/MirrorBasic.unity |   746 +
 .../Examples/Basic/Scenes/MirrorBasic.unity.meta   |    14 +
 Assets/Mirror/Examples/Basic/Scripts.meta          |     8 +
 .../Examples/Basic/Scripts/BasicNetManager.cs      |    30 +
 .../Examples/Basic/Scripts/BasicNetManager.cs.meta |    18 +
 Assets/Mirror/Examples/Basic/Scripts/CanvasUI.cs   |    28 +
 .../Mirror/Examples/Basic/Scripts/CanvasUI.cs.meta |    18 +
 Assets/Mirror/Examples/Basic/Scripts/Player.cs     |   181 +
 .../Mirror/Examples/Basic/Scripts/Player.cs.meta   |    18 +
 Assets/Mirror/Examples/Basic/Scripts/PlayerUI.cs   |    41 +
 .../Mirror/Examples/Basic/Scripts/PlayerUI.cs.meta |    18 +
 Assets/Mirror/Examples/Benchmark.meta              |     8 +
 Assets/Mirror/Examples/Benchmark/Materials.meta    |     8 +
 Assets/Mirror/Examples/Benchmark/Materials/Red.mat |    77 +
 .../Examples/Benchmark/Materials/Red.mat.meta      |    15 +
 .../Mirror/Examples/Benchmark/Materials/White.mat  |    77 +
 .../Examples/Benchmark/Materials/White.mat.meta    |    15 +
 Assets/Mirror/Examples/Benchmark/Prefabs.meta      |     8 +
 .../Examples/Benchmark/Prefabs/Monster.prefab      |   152 +
 .../Examples/Benchmark/Prefabs/Monster.prefab.meta |    14 +
 .../Examples/Benchmark/Prefabs/Player.prefab       |   150 +
 .../Examples/Benchmark/Prefabs/Player.prefab.meta  |    14 +
 Assets/Mirror/Examples/Benchmark/Scenes.meta       |     8 +
 .../Benchmark/Scenes/MirrorBenchmark.unity         |   538 +
 .../Benchmark/Scenes/MirrorBenchmark.unity.meta    |    14 +
 Assets/Mirror/Examples/Benchmark/Scripts.meta      |     8 +
 .../Benchmark/Scripts/BenchmarkNetworkManager.cs   |    52 +
 .../Scripts/BenchmarkNetworkManager.cs.meta        |    18 +
 .../Examples/Benchmark/Scripts/MonsterMovement.cs  |    57 +
 .../Benchmark/Scripts/MonsterMovement.cs.meta      |    18 +
 .../Examples/Benchmark/Scripts/PlayerMovement.cs   |    31 +
 .../Benchmark/Scripts/PlayerMovement.cs.meta       |    18 +
 Assets/Mirror/Examples/BenchmarkIdle.meta          |     8 +
 .../BenchmarkIdle/BenchmarkIdleNetworkManager.cs   |    98 +
 .../BenchmarkIdleNetworkManager.cs.meta            |    18 +
 .../BenchmarkIdle/MirrorBenchmarkIdle.unity        |   519 +
 .../BenchmarkIdle/MirrorBenchmarkIdle.unity.meta   |    14 +
 Assets/Mirror/Examples/BenchmarkIdle/Npc.cs        |    39 +
 Assets/Mirror/Examples/BenchmarkIdle/Npc.cs.meta   |    18 +
 Assets/Mirror/Examples/BenchmarkIdle/Npc.mat       |    77 +
 Assets/Mirror/Examples/BenchmarkIdle/Npc.mat.meta  |    15 +
 Assets/Mirror/Examples/BenchmarkIdle/Npc.prefab    |   119 +
 .../Mirror/Examples/BenchmarkIdle/Npc.prefab.meta  |    14 +
 Assets/Mirror/Examples/BenchmarkIdle/Player.cs     |    87 +
 .../Mirror/Examples/BenchmarkIdle/Player.cs.meta   |    18 +
 Assets/Mirror/Examples/BenchmarkIdle/Player.mat    |    77 +
 .../Mirror/Examples/BenchmarkIdle/Player.mat.meta  |    15 +
 Assets/Mirror/Examples/BenchmarkIdle/Player.prefab |   154 +
 .../Examples/BenchmarkIdle/Player.prefab.meta      |    14 +
 Assets/Mirror/Examples/BenchmarkIdle/Readme.txt    |     9 +
 .../Mirror/Examples/BenchmarkIdle/Readme.txt.meta  |    10 +
 Assets/Mirror/Examples/BenchmarkIdle/_Readme.txt   |     4 +
 .../Mirror/Examples/BenchmarkIdle/_Readme.txt.meta |    10 +
 Assets/Mirror/Examples/BenchmarkPrediction.meta    |     8 +
 .../Examples/BenchmarkPrediction/BallMaterial.mat  |    80 +
 .../BenchmarkPrediction/BallMaterial.mat.meta      |    15 +
 .../MirrorPredictionBenchmark.unity                |  1002 +
 .../MirrorPredictionBenchmark.unity.meta           |    14 +
 .../NetworkManagerPredictionBenchmark.cs           |    50 +
 .../NetworkManagerPredictionBenchmark.cs.meta      |    18 +
 .../BenchmarkPrediction/PlayerSpectator.prefab     |    50 +
 .../PlayerSpectator.prefab.meta                    |    14 +
 .../BenchmarkPrediction/PredictedBall.prefab       |   186 +
 .../BenchmarkPrediction/PredictedBall.prefab.meta  |    14 +
 .../Examples/BenchmarkPrediction/RandomForce.cs    |    52 +
 .../BenchmarkPrediction/RandomForce.cs.meta        |    18 +
 .../Mirror/Examples/BenchmarkPrediction/Readme.md  |    24 +
 .../Examples/BenchmarkPrediction/Readme.md.meta    |    10 +
 .../Examples/BenchmarkPrediction/WallMaterial.mat  |    78 +
 .../BenchmarkPrediction/WallMaterial.mat.meta      |    15 +
 Assets/Mirror/Examples/BenchmarkStinkySteak.meta   |     8 +
 .../BenchmarkStinkySteak/BehaviourConfig.asset     |    33 +
 .../BehaviourConfig.asset.meta                     |    15 +
 .../BenchmarkStinkySteak/Dependencies.meta         |     8 +
 .../Dependencies/Unity-Simulation-Timer.meta       |     8 +
 .../Dependencies/Unity-Simulation-Timer/LICENSE.md |    21 +
 .../Unity-Simulation-Timer/LICENSE.md.meta         |    14 +
 .../Dependencies/Unity-Simulation-Timer/README.md  |    63 +
 .../Unity-Simulation-Timer/README.md.meta          |    14 +
 .../Unity-Simulation-Timer/Runtime.meta            |     8 +
 .../Runtime/PauseableSimulationTimer.cs            |    63 +
 .../Runtime/PauseableSimulationTimer.cs.meta       |    18 +
 .../Runtime/SimulationTimer.cs                     |    32 +
 .../Runtime/SimulationTimer.cs.meta                |    18 +
 .../Unity-Simulation-Timer/package.json            |    15 +
 .../Unity-Simulation-Timer/package.json.meta       |    14 +
 .../Dependencies/netcode-benchmarker-util.meta     |     8 +
 .../netcode-benchmarker-util/LICENSE.md            |    21 +
 .../netcode-benchmarker-util/LICENSE.md.meta       |    14 +
 .../netcode-benchmarker-util/Runtime.meta          |     8 +
 .../netcode-benchmarker-util/Runtime/Config.meta   |     8 +
 .../Runtime/Config/DefaultBehaviourConfig.asset    |    33 +
 .../Config/DefaultBehaviourConfig.asset.meta       |    15 +
 .../netcode-benchmarker-util/Runtime/Prefabs.meta  |     8 +
 .../Runtime/Prefabs/BaseGUIGame.prefab             |  1499 ++
 .../Runtime/Prefabs/BaseGUIGame.prefab.meta        |    14 +
 .../netcode-benchmarker-util/Runtime/Scripts.meta  |     8 +
 .../Runtime/Scripts/BehaviourConfig.cs             |    45 +
 .../Runtime/Scripts/BehaviourConfig.cs.meta        |    18 +
 .../Runtime/Scripts/BehaviourWrapper.meta          |     8 +
 .../Scripts/BehaviourWrapper/IMoveWrapper.cs       |    10 +
 .../Scripts/BehaviourWrapper/IMoveWrapper.cs.meta  |    18 +
 .../Scripts/BehaviourWrapper/SinMoveYWrapper.cs    |    45 +
 .../BehaviourWrapper/SinMoveYWrapper.cs.meta       |    18 +
 .../BehaviourWrapper/SinRandomMoveWrapper.cs       |    40 +
 .../BehaviourWrapper/SinRandomMoveWrapper.cs.meta  |    18 +
 .../Scripts/BehaviourWrapper/WanderMoveWrapper.cs  |    86 +
 .../BehaviourWrapper/WanderMoveWrapper.cs.meta     |    18 +
 .../Runtime/Scripts/RandomVector3.cs               |    16 +
 .../Runtime/Scripts/RandomVector3.cs.meta          |    18 +
 .../Runtime/Scripts/UI.meta                        |     8 +
 .../Runtime/Scripts/UI/BaseGUIGame.cs              |    94 +
 .../Runtime/Scripts/UI/BaseGUIGame.cs.meta         |    18 +
 .../netcode-benchmarker-util/Runtime/Shaders.meta  |     8 +
 .../Runtime/Shaders/Unlit.mat                      |    28 +
 .../Runtime/Shaders/Unlit.mat.meta                 |    15 +
 .../Runtime/Shaders/Unlit.shader                   |    37 +
 .../Runtime/Shaders/Unlit.shader.meta              |    17 +
 .../Examples/BenchmarkStinkySteak/LICENSE.md       |    21 +
 .../Examples/BenchmarkStinkySteak/LICENSE.md.meta  |    14 +
 .../Examples/BenchmarkStinkySteak/Main.unity       |   337 +
 .../Examples/BenchmarkStinkySteak/Main.unity.meta  |    14 +
 .../Examples/BenchmarkStinkySteak/Prefabs.meta     |     8 +
 .../BenchmarkStinkySteak/Prefabs/GUIGame.prefab    |  1371 ++
 .../Prefabs/GUIGame.prefab.meta                    |    14 +
 .../Prefabs/NetworkManager.prefab                  |   111 +
 .../Prefabs/NetworkManager.prefab.meta             |    14 +
 .../Prefabs/PlayerDummy.prefab                     |    50 +
 .../Prefabs/PlayerDummy.prefab.meta                |    14 +
 .../Prefabs/SphereMoveAllAxis.prefab               |   181 +
 .../Prefabs/SphereMoveAllAxis.prefab.meta          |    14 +
 .../Prefabs/SphereMoveWander.prefab                |   181 +
 .../Prefabs/SphereMoveWander.prefab.meta           |    14 +
 .../Prefabs/SphereMoveY.prefab                     |   181 +
 .../Prefabs/SphereMoveY.prefab.meta                |    14 +
 .../Examples/BenchmarkStinkySteak/Scripts.meta     |     8 +
 .../BenchmarkStinkySteak/Scripts/GUIGame.cs        |    65 +
 .../BenchmarkStinkySteak/Scripts/GUIGame.cs.meta   |    18 +
 .../Scripts/SineMoveRandomBehaviour.cs             |    27 +
 .../Scripts/SineMoveRandomBehaviour.cs.meta        |    18 +
 .../Scripts/SineMoveYBehaviour.cs                  |    27 +
 .../Scripts/SineMoveYBehaviour.cs.meta             |    18 +
 .../Scripts/WanderMoveBehaviour.cs                 |    27 +
 .../Scripts/WanderMoveBehaviour.cs.meta            |    18 +
 .../Examples/BenchmarkStinkySteak/Shaders.meta     |     8 +
 .../BenchmarkStinkySteak/Shaders/Unlit.mat         |    28 +
 .../BenchmarkStinkySteak/Shaders/Unlit.mat.meta    |    15 +
 .../BenchmarkStinkySteak/Shaders/Unlit.shader      |    37 +
 .../BenchmarkStinkySteak/Shaders/Unlit.shader.meta |    17 +
 .../Examples/BenchmarkStinkySteak/_Readme.txt      |    10 +
 .../Examples/BenchmarkStinkySteak/_Readme.txt.meta |    14 +
 Assets/Mirror/Examples/Billiards.meta              |     8 +
 Assets/Mirror/Examples/Billiards/Ball.meta         |     8 +
 .../Examples/Billiards/Ball/Ball.physicMaterial    |    14 +
 .../Billiards/Ball/Ball.physicMaterial.meta        |    15 +
 Assets/Mirror/Examples/Billiards/Ball/Red.mat      |    80 +
 Assets/Mirror/Examples/Billiards/Ball/Red.mat.meta |    15 +
 Assets/Mirror/Examples/Billiards/Ball/Red.prefab   |   181 +
 .../Mirror/Examples/Billiards/Ball/Red.prefab.meta |    14 +
 Assets/Mirror/Examples/Billiards/Ball/RedBall.cs   |    15 +
 .../Mirror/Examples/Billiards/Ball/RedBall.cs.meta |    18 +
 Assets/Mirror/Examples/Billiards/Ball/White.mat    |    80 +
 .../Mirror/Examples/Billiards/Ball/White.mat.meta  |    15 +
 Assets/Mirror/Examples/Billiards/Ball/White.prefab |   314 +
 .../Examples/Billiards/Ball/White.prefab.meta      |    14 +
 Assets/Mirror/Examples/Billiards/Ball/WhiteBall.cs |   107 +
 .../Examples/Billiards/Ball/WhiteBall.cs.meta      |    18 +
 .../Examples/Billiards/MirrorBilliards.unity       |  1445 ++
 .../Examples/Billiards/MirrorBilliards.unity.meta  |    14 +
 Assets/Mirror/Examples/Billiards/Player.prefab     |    50 +
 .../Mirror/Examples/Billiards/Player.prefab.meta   |    14 +
 Assets/Mirror/Examples/Billiards/Table.meta        |     8 +
 .../Examples/Billiards/Table/Billiard Table.prefab |   468 +
 .../Billiards/Table/Billiard Table.prefab.meta     |    14 +
 .../Billiards/Table/BilliardTable Model.obj        |  4468 ++++
 .../Billiards/Table/BilliardTable Model.obj.meta   |   113 +
 .../Examples/Billiards/Table/BilliardTable.mtl     |    52 +
 .../Billiards/Table/BilliardTable.mtl.meta         |    14 +
 Assets/Mirror/Examples/Billiards/Table/Body.mat    |    81 +
 .../Mirror/Examples/Billiards/Table/Body.mat.meta  |    15 +
 Assets/Mirror/Examples/Billiards/Table/Edge.mat    |    80 +
 .../Mirror/Examples/Billiards/Table/Edge.mat.meta  |    15 +
 Assets/Mirror/Examples/Billiards/Table/Felt.mat    |    80 +
 .../Mirror/Examples/Billiards/Table/Felt.mat.meta  |    15 +
 Assets/Mirror/Examples/Billiards/Table/Holes.mat   |    80 +
 .../Mirror/Examples/Billiards/Table/Holes.mat.meta |    15 +
 Assets/Mirror/Examples/Billiards/Table/Lamp.mat    |    80 +
 .../Mirror/Examples/Billiards/Table/Lamp.mat.meta  |    15 +
 Assets/Mirror/Examples/Billiards/Table/License.txt |     3 +
 .../Examples/Billiards/Table/License.txt.meta      |    10 +
 Assets/Mirror/Examples/Billiards/Table/Pockets.mat |    82 +
 .../Examples/Billiards/Table/Pockets.mat.meta      |    15 +
 Assets/Mirror/Examples/Billiards/_Readme.txt       |    18 +
 Assets/Mirror/Examples/Billiards/_Readme.txt.meta  |    10 +
 Assets/Mirror/Examples/BilliardsPredicted.meta     |     8 +
 .../Mirror/Examples/BilliardsPredicted/Ball.meta   |     8 +
 .../Examples/BilliardsPredicted/Ball/Pockets.cs    |    42 +
 .../BilliardsPredicted/Ball/Pockets.cs.meta        |    18 +
 .../Examples/BilliardsPredicted/Ball/Red.mat       |    80 +
 .../Examples/BilliardsPredicted/Ball/Red.mat.meta  |    15 +
 .../BilliardsPredicted/Ball/RedBallPredicted.cs    |    22 +
 .../Ball/RedBallPredicted.cs.meta                  |    18 +
 .../BilliardsPredicted/Ball/RedPredicted.prefab    |   184 +
 .../Ball/RedPredicted.prefab.meta                  |    14 +
 .../Examples/BilliardsPredicted/Ball/White.mat     |    80 +
 .../BilliardsPredicted/Ball/White.mat.meta         |    15 +
 .../BilliardsPredicted/Ball/WhiteBallPredicted.cs  |   186 +
 .../Ball/WhiteBallPredicted.cs.meta                |    18 +
 .../BilliardsPredicted/Ball/WhitePredicted.prefab  |   318 +
 .../Ball/WhitePredicted.prefab.meta                |    14 +
 .../MirrorBilliardsPredicted.unity                 |  1410 ++
 .../MirrorBilliardsPredicted.unity.meta            |    14 +
 .../Mirror/Examples/BilliardsPredicted/Player.meta |     8 +
 .../BilliardsPredicted/Player/PlayerPredicted.cs   |    91 +
 .../Player/PlayerPredicted.cs.meta                 |    18 +
 .../Player/PlayerPredicted.prefab                  |    66 +
 .../Player/PlayerPredicted.prefab.meta             |    14 +
 .../Mirror/Examples/BilliardsPredicted/_Readme.txt |    19 +
 .../Examples/BilliardsPredicted/_Readme.txt.meta   |    10 +
 Assets/Mirror/Examples/CCU.meta                    |     8 +
 Assets/Mirror/Examples/CCU/CCUNetworkManager.cs    |    93 +
 .../Mirror/Examples/CCU/CCUNetworkManager.cs.meta  |    18 +
 Assets/Mirror/Examples/CCU/MirrorCCU.unity         |   541 +
 Assets/Mirror/Examples/CCU/MirrorCCU.unity.meta    |    14 +
 Assets/Mirror/Examples/CCU/Monster.cs              |    55 +
 Assets/Mirror/Examples/CCU/Monster.cs.meta         |    18 +
 Assets/Mirror/Examples/CCU/Monster.prefab          |   152 +
 Assets/Mirror/Examples/CCU/Monster.prefab.meta     |    14 +
 Assets/Mirror/Examples/CCU/Player.cs               |    99 +
 Assets/Mirror/Examples/CCU/Player.cs.meta          |    18 +
 Assets/Mirror/Examples/CCU/Player.prefab           |   175 +
 Assets/Mirror/Examples/CCU/Player.prefab.meta      |    14 +
 Assets/Mirror/Examples/CCU/Readme.txt              |     9 +
 Assets/Mirror/Examples/CCU/Readme.txt.meta         |    10 +
 Assets/Mirror/Examples/CCU/Red.mat                 |    77 +
 Assets/Mirror/Examples/CCU/Red.mat.meta            |    15 +
 Assets/Mirror/Examples/CCU/White.mat               |    77 +
 Assets/Mirror/Examples/CCU/White.mat.meta          |    15 +
 Assets/Mirror/Examples/CharacterSelection.meta     |     8 +
 .../Examples/CharacterSelection/Materials.meta     |     8 +
 .../CharacterSelection/Materials/MaterialBlack.mat |    80 +
 .../Materials/MaterialBlack.mat.meta               |    15 +
 .../CharacterSelection/Materials/MaterialBrown.mat |    80 +
 .../Materials/MaterialBrown.mat.meta               |    15 +
 .../Materials/MaterialDesert.mat                   |    80 +
 .../Materials/MaterialDesert.mat.meta              |    15 +
 .../CharacterSelection/Materials/MaterialFloor.mat |    80 +
 .../Materials/MaterialFloor.mat.meta               |    15 +
 .../CharacterSelection/Materials/MaterialGold.mat  |    80 +
 .../Materials/MaterialGold.mat.meta                |    15 +
 .../Materials/MaterialGreenDark.mat                |    80 +
 .../Materials/MaterialGreenDark.mat.meta           |    15 +
 .../CharacterSelection/Materials/MaterialIcon1.mat |    80 +
 .../Materials/MaterialIcon1.mat.meta               |    15 +
 .../CharacterSelection/Materials/MaterialRed.mat   |    80 +
 .../Materials/MaterialRed.mat.meta                 |    15 +
 .../Materials/MaterialSilver.mat                   |    80 +
 .../Materials/MaterialSilver.mat.meta              |    15 +
 .../CharacterSelection/Materials/MaterialWhite.mat |    80 +
 .../Materials/MaterialWhite.mat.meta               |    15 +
 .../MirrorCharacterSelection.unity                 |  3307 +++
 .../MirrorCharacterSelection.unity.meta            |    14 +
 .../MirrorCharacterSelectionNoCharacter.unity      |  3308 +++
 .../MirrorCharacterSelectionNoCharacter.unity.meta |    14 +
 .../MirrorCharacterSelectionPreScene.unity         |   332 +
 .../MirrorCharacterSelectionPreScene.unity.meta    |    14 +
 .../Examples/CharacterSelection/Prefabs.meta       |     8 +
 .../Prefabs/CharacterData.prefab                   |    67 +
 .../Prefabs/CharacterData.prefab.meta              |    14 +
 .../Prefabs/CharacterSelection.prefab              |  2696 +++
 .../Prefabs/CharacterSelection.prefab.meta         |    14 +
 .../CharacterSelection/Prefabs/Characters.meta     |     8 +
 .../Prefabs/Characters/CharacterAssault.prefab     |  1961 ++
 .../Characters/CharacterAssault.prefab.meta        |    14 +
 .../Prefabs/Characters/CharacterHeavy.prefab       |  1478 ++
 .../Prefabs/Characters/CharacterHeavy.prefab.meta  |    14 +
 .../Prefabs/Characters/CharacterMedic.prefab       |  1157 +
 .../Prefabs/Characters/CharacterMedic.prefab.meta  |    14 +
 .../CharacterSelection/Prefabs/PlayerEmpty.prefab  |    66 +
 .../Prefabs/PlayerEmpty.prefab.meta                |    14 +
 .../Examples/CharacterSelection/Scripts.meta       |     8 +
 .../CharacterSelection/Scripts/CanvasReferencer.cs |   194 +
 .../Scripts/CanvasReferencer.cs.meta               |    18 +
 .../CharacterSelection/Scripts/CharacterData.cs    |    25 +
 .../Scripts/CharacterData.cs.meta                  |    18 +
 .../Scripts/CharacterSelection.cs                  |    62 +
 .../Scripts/CharacterSelection.cs.meta             |    18 +
 .../Scripts/NetworkManagerCharacterSelection.cs    |   135 +
 .../NetworkManagerCharacterSelection.cs.meta       |    18 +
 .../CharacterSelection/Scripts/PlayerEmpty.cs      |    22 +
 .../CharacterSelection/Scripts/PlayerEmpty.cs.meta |    18 +
 .../CharacterSelection/Scripts/SceneCamera.cs      |    59 +
 .../CharacterSelection/Scripts/SceneCamera.cs.meta |    18 +
 .../CharacterSelection/Scripts/SceneReferencer.cs  |    47 +
 .../Scripts/SceneReferencer.cs.meta                |    18 +
 .../CharacterSelection/Scripts/ScriptAnimations.cs |    33 +
 .../Scripts/ScriptAnimations.cs.meta               |    18 +
 .../CharacterSelection/Scripts/StaticVariables.cs  |    13 +
 .../Scripts/StaticVariables.cs.meta                |    18 +
 .../Examples/CharacterSelection/Textures.meta      |     8 +
 .../Textures/IconRandomColour.png                  |   Bin 0 -> 89302 bytes
 .../Textures/IconRandomColour.png.meta             |   166 +
 .../Textures/IconResetColour.png                   |   Bin 0 -> 18042 bytes
 .../Textures/IconResetColour.png.meta              |   166 +
 .../Textures/IconStickPerson.png                   |   Bin 0 -> 11503 bytes
 .../Textures/IconStickPerson.png.meta              |   166 +
 .../CharacterSelection/Textures/dirtMoon.jpg       |   Bin 0 -> 20017 bytes
 .../CharacterSelection/Textures/dirtMoon.jpg.meta  |   166 +
 .../Mirror/Examples/CharacterSelection/_ReadMe.txt |    13 +
 .../Examples/CharacterSelection/_ReadMe.txt.meta   |    14 +
 Assets/Mirror/Examples/Chat.meta                   |     8 +
 Assets/Mirror/Examples/Chat/Prefabs.meta           |     8 +
 Assets/Mirror/Examples/Chat/Prefabs/Player.prefab  |    67 +
 .../Examples/Chat/Prefabs/Player.prefab.meta       |    14 +
 Assets/Mirror/Examples/Chat/Scenes.meta            |     8 +
 .../Mirror/Examples/Chat/Scenes/MirrorChat.unity   |  3706 +++
 .../Examples/Chat/Scenes/MirrorChat.unity.meta     |    14 +
 Assets/Mirror/Examples/Chat/Scripts.meta           |     8 +
 .../Examples/Chat/Scripts/ChatAuthenticator.cs     |   213 +
 .../Chat/Scripts/ChatAuthenticator.cs.meta         |    18 +
 .../Examples/Chat/Scripts/ChatNetworkManager.cs    |    34 +
 .../Chat/Scripts/ChatNetworkManager.cs.meta        |    18 +
 Assets/Mirror/Examples/Chat/Scripts/ChatUI.cs      |   100 +
 Assets/Mirror/Examples/Chat/Scripts/ChatUI.cs.meta |    18 +
 Assets/Mirror/Examples/Chat/Scripts/LoginUI.cs     |    52 +
 .../Mirror/Examples/Chat/Scripts/LoginUI.cs.meta   |    18 +
 Assets/Mirror/Examples/Chat/Scripts/Player.cs      |    18 +
 Assets/Mirror/Examples/Chat/Scripts/Player.cs.meta |    18 +
 Assets/Mirror/Examples/CouchCoop.meta              |     8 +
 Assets/Mirror/Examples/CouchCoop/Materials.meta    |     8 +
 .../CouchCoop/Materials/MaterialColliders.mat      |    82 +
 .../CouchCoop/Materials/MaterialColliders.mat.meta |    15 +
 .../CouchCoop/Materials/MaterialGround.mat         |    80 +
 .../CouchCoop/Materials/MaterialGround.mat.meta    |    15 +
 .../CouchCoop/Materials/MaterialPlatform1.mat      |    80 +
 .../CouchCoop/Materials/MaterialPlatform1.mat.meta |    15 +
 .../CouchCoop/Materials/MaterialPlatform2.mat      |    80 +
 .../CouchCoop/Materials/MaterialPlatform2.mat.meta |    15 +
 .../CouchCoop/Materials/MaterialPlayer.mat         |    82 +
 .../CouchCoop/Materials/MaterialPlayer.mat.meta    |    15 +
 .../Examples/CouchCoop/MirrorCouchCoop.unity       |  3630 +++
 .../Examples/CouchCoop/MirrorCouchCoop.unity.meta  |    14 +
 Assets/Mirror/Examples/CouchCoop/Prefabs.meta      |     8 +
 .../Examples/CouchCoop/Prefabs/CouchPlayer.prefab  |   526 +
 .../CouchCoop/Prefabs/CouchPlayer.prefab.meta      |    14 +
 .../CouchCoop/Prefabs/CouchPlayerManager.prefab    |    73 +
 .../Prefabs/CouchPlayerManager.prefab.meta         |    14 +
 Assets/Mirror/Examples/CouchCoop/Scripts.meta      |     8 +
 .../Examples/CouchCoop/Scripts/CameraViewForAll.cs |    73 +
 .../CouchCoop/Scripts/CameraViewForAll.cs.meta     |    18 +
 .../Examples/CouchCoop/Scripts/CanvasScript.cs     |    32 +
 .../CouchCoop/Scripts/CanvasScript.cs.meta         |    18 +
 .../Examples/CouchCoop/Scripts/CouchPlayer.cs      |   129 +
 .../Examples/CouchCoop/Scripts/CouchPlayer.cs.meta |    18 +
 .../CouchCoop/Scripts/CouchPlayerManager.cs        |    69 +
 .../CouchCoop/Scripts/CouchPlayerManager.cs.meta   |    18 +
 .../Examples/CouchCoop/Scripts/MovingPlatform.cs   |    79 +
 .../CouchCoop/Scripts/MovingPlatform.cs.meta       |    18 +
 .../Examples/CouchCoop/Scripts/PlatformMovement.cs |    49 +
 .../CouchCoop/Scripts/PlatformMovement.cs.meta     |    18 +
 Assets/Mirror/Examples/CouchCoop/_ReadMe.txt       |    16 +
 Assets/Mirror/Examples/CouchCoop/_ReadMe.txt.meta  |    14 +
 Assets/Mirror/Examples/Discovery.meta              |     8 +
 Assets/Mirror/Examples/Discovery/Prefabs.meta      |     8 +
 .../Examples/Discovery/Prefabs/Player.prefab       |   114 +
 .../Examples/Discovery/Prefabs/Player.prefab.meta  |    14 +
 Assets/Mirror/Examples/Discovery/Scenes.meta       |     8 +
 .../Discovery/Scenes/MirrorDiscovery.unity         |   790 +
 .../Discovery/Scenes/MirrorDiscovery.unity.meta    |    14 +
 Assets/Mirror/Examples/EdgegapLobby.meta           |     8 +
 .../Examples/EdgegapLobby/EdgegapLobbyTanks.meta   |     8 +
 .../Examples/EdgegapLobby/EdgegapLobbyTanks.unity  |  1128 +
 .../EdgegapLobby/EdgegapLobbyTanks.unity.meta      |    14 +
 .../EdgegapLobby/EdgegapLobbyTanks/NavMesh.asset   |   Bin 0 -> 6564 bytes
 .../EdgegapLobbyTanks/NavMesh.asset.meta           |    15 +
 Assets/Mirror/Examples/EdgegapLobby/Prefabs.meta   |     8 +
 .../Examples/EdgegapLobby/Prefabs/LobbyUI.prefab   |  4617 ++++
 .../EdgegapLobby/Prefabs/LobbyUI.prefab.meta       |    14 +
 .../EdgegapLobby/Prefabs/LobbyUIEntry.prefab       |   294 +
 .../EdgegapLobby/Prefabs/LobbyUIEntry.prefab.meta  |    14 +
 Assets/Mirror/Examples/EdgegapLobby/Scripts.meta   |     8 +
 .../Examples/EdgegapLobby/Scripts/UILobbyCreate.cs |    54 +
 .../EdgegapLobby/Scripts/UILobbyCreate.cs.meta     |    10 +
 .../Examples/EdgegapLobby/Scripts/UILobbyEntry.cs  |    37 +
 .../EdgegapLobby/Scripts/UILobbyEntry.cs.meta      |    18 +
 .../Examples/EdgegapLobby/Scripts/UILobbyList.cs   |    91 +
 .../EdgegapLobby/Scripts/UILobbyList.cs.meta       |    10 +
 .../Examples/EdgegapLobby/Scripts/UILobbyStatus.cs |   121 +
 .../EdgegapLobby/Scripts/UILobbyStatus.cs.meta     |    10 +
 Assets/Mirror/Examples/EdgegapLobby/_ReadMe.txt    |    11 +
 .../Mirror/Examples/EdgegapLobby/_ReadMe.txt.meta  |    14 +
 Assets/Mirror/Examples/HexSpatialHash.meta         |     8 +
 .../Examples/HexSpatialHash/Hex2DSpatialHash.unity |   510 +
 .../HexSpatialHash/Hex2DSpatialHash.unity.meta     |    14 +
 .../Examples/HexSpatialHash/Hex3DSpatialHash.unity |   509 +
 .../HexSpatialHash/Hex3DSpatialHash.unity.meta     |    14 +
 .../Mirror/Examples/HexSpatialHash/Mateirals.meta  |     8 +
 .../HexSpatialHash/Mateirals/RandomColor.mat       |    77 +
 .../HexSpatialHash/Mateirals/RandomColor.mat.meta  |    15 +
 Assets/Mirror/Examples/HexSpatialHash/Prefabs.meta |     8 +
 .../HexSpatialHash/Prefabs/Hex2DPlayer.prefab      |   170 +
 .../HexSpatialHash/Prefabs/Hex2DPlayer.prefab.meta |    14 +
 .../HexSpatialHash/Prefabs/Hex3DPlayer.prefab      |   182 +
 .../HexSpatialHash/Prefabs/Hex3DPlayer.prefab.meta |    14 +
 .../HexSpatialHash/Prefabs/SpawnPrefab.prefab      |   118 +
 .../HexSpatialHash/Prefabs/SpawnPrefab.prefab.meta |    14 +
 Assets/Mirror/Examples/HexSpatialHash/Scripts.meta |     8 +
 .../HexSpatialHash/Scripts/Hex2DNetworkManager.cs  |    86 +
 .../Scripts/Hex2DNetworkManager.cs.meta            |    18 +
 .../Examples/HexSpatialHash/Scripts/Hex2DPlayer.cs |    49 +
 .../HexSpatialHash/Scripts/Hex2DPlayer.cs.meta     |    18 +
 .../HexSpatialHash/Scripts/Hex2DPlayerCamera.cs    |    95 +
 .../Scripts/Hex2DPlayerCamera.cs.meta              |    18 +
 .../HexSpatialHash/Scripts/Hex3DNetworkManager.cs  |    70 +
 .../Scripts/Hex3DNetworkManager.cs.meta            |    18 +
 .../Examples/HexSpatialHash/Scripts/Hex3DPlayer.cs |    47 +
 .../HexSpatialHash/Scripts/Hex3DPlayer.cs.meta     |    18 +
 Assets/Mirror/Examples/LagCompensation.meta        |     8 +
 .../Mirror/Examples/LagCompensation/Capture2D.cs   |    32 +
 .../Examples/LagCompensation/Capture2D.cs.meta     |    10 +
 .../Mirror/Examples/LagCompensation/ClientCube.cs  |   240 +
 .../Examples/LagCompensation/ClientCube.cs.meta    |    10 +
 .../Examples/LagCompensation/ClientMaterial.mat    |    80 +
 .../LagCompensation/ClientMaterial.mat.meta        |    15 +
 .../LagCompensation/MirrorLagCompensation.unity    |   483 +
 .../MirrorLagCompensation.unity.meta               |    14 +
 .../Mirror/Examples/LagCompensation/ServerCube.cs  |   212 +
 .../Examples/LagCompensation/ServerCube.cs.meta    |    18 +
 .../Examples/LagCompensation/ServerMaterial.mat    |    80 +
 .../LagCompensation/ServerMaterial.mat.meta        |    15 +
 .../Mirror/Examples/LagCompensation/Snapshot3D.cs  |    26 +
 .../Examples/LagCompensation/Snapshot3D.cs.meta    |    18 +
 .../Examples/LagCompensation/_DISABLE VSYNC_       |     2 +
 .../Examples/LagCompensation/_DISABLE VSYNC_.meta  |    14 +
 Assets/Mirror/Examples/LagCompensation/_README.txt |     6 +
 .../Examples/LagCompensation/_README.txt.meta      |    14 +
 Assets/Mirror/Examples/Mirror.Examples.asmdef      |    19 +
 Assets/Mirror/Examples/Mirror.Examples.asmdef.meta |    14 +
 Assets/Mirror/Examples/MultipleAdditiveScenes.meta |     8 +
 .../Examples/MultipleAdditiveScenes/Materials.meta |     8 +
 .../MultipleAdditiveScenes/Materials/Physics.meta  |     8 +
 .../Materials/Physics/Icosphere.physicMaterial     |    14 +
 .../Physics/Icosphere.physicMaterial.meta          |    15 +
 .../Materials/Physics/Player.physicMaterial        |    14 +
 .../Materials/Physics/Player.physicMaterial.meta   |    15 +
 .../Materials/Physics/RoomBounce.physicMaterial    |    14 +
 .../Physics/RoomBounce.physicMaterial.meta         |    15 +
 .../MultipleAdditiveScenes/Materials/Render.meta   |     8 +
 .../Materials/Render/PlayArea.mat                  |    77 +
 .../Materials/Render/PlayArea.mat.meta             |    15 +
 .../Materials/Render/Player.mat                    |    77 +
 .../Materials/Render/Player.mat.meta               |    15 +
 .../Materials/Render/Prize.mat                     |    77 +
 .../Materials/Render/Prize.mat.meta                |    15 +
 .../Examples/MultipleAdditiveScenes/Models.meta    |     8 +
 .../MultipleAdditiveScenes/Models/Icosphere.meta   |     8 +
 .../Models/Icosphere/Icosphere.obj                 |   119 +
 .../Models/Icosphere/Icosphere.obj.meta            |   111 +
 .../Models/Icosphere/Materials.meta                |     8 +
 .../Models/Icosphere/Materials/Icosphere.mat       |    77 +
 .../Models/Icosphere/Materials/Icosphere.mat.meta  |    15 +
 .../Examples/MultipleAdditiveScenes/Prefabs.meta   |     8 +
 .../Prefabs/Icosphere.prefab                       |   233 +
 .../Prefabs/Icosphere.prefab.meta                  |    14 +
 .../Prefabs/PlayerReliable.prefab                  |   406 +
 .../Prefabs/PlayerReliable.prefab.meta             |    15 +
 .../Prefabs/PlayerUnreliable.prefab                |   406 +
 .../Prefabs/PlayerUnreliable.prefab.meta           |    15 +
 .../MultipleAdditiveScenes/Prefabs/Reward.prefab   |   198 +
 .../Prefabs/Reward.prefab.meta                     |    15 +
 .../Examples/MultipleAdditiveScenes/README.md      |    34 +
 .../Examples/MultipleAdditiveScenes/README.md.meta |    14 +
 .../Examples/MultipleAdditiveScenes/Scenes.meta    |     8 +
 .../Scenes/MirrorMultipleAdditiveScenesGame.unity  |   779 +
 .../MirrorMultipleAdditiveScenesGame.unity.meta    |    14 +
 .../Scenes/MirrorMultipleAdditiveScenesMain.meta   |     8 +
 .../Scenes/MirrorMultipleAdditiveScenesMain.unity  |   878 +
 .../MirrorMultipleAdditiveScenesMain.unity.meta    |    14 +
 .../LightingData.asset                             |   Bin 0 -> 18160 bytes
 .../LightingData.asset.meta                        |    15 +
 .../ReflectionProbe-0.exr                          |   Bin 0 -> 110488 bytes
 .../ReflectionProbe-0.exr.meta                     |    99 +
 .../Examples/MultipleAdditiveScenes/Scripts.meta   |     8 +
 .../Scripts/MultiSceneNetManager.cs                |   179 +
 .../Scripts/MultiSceneNetManager.cs.meta           |    18 +
 .../Scripts/PhysicsCollision.cs                    |    46 +
 .../Scripts/PhysicsCollision.cs.meta               |    18 +
 .../MultipleAdditiveScenes/Scripts/PlayerScore.cs  |    30 +
 .../Scripts/PlayerScore.cs.meta                    |    18 +
 .../MultipleAdditiveScenes/Scripts/Reward.cs       |    65 +
 .../MultipleAdditiveScenes/Scripts/Reward.cs.meta  |    18 +
 .../MultipleAdditiveScenes/Scripts/Spawner.cs      |   107 +
 .../MultipleAdditiveScenes/Scripts/Spawner.cs.meta |    18 +
 Assets/Mirror/Examples/MultipleMatches.meta        |     8 +
 .../Mirror/Examples/MultipleMatches/Prefabs.meta   |     8 +
 .../MultipleMatches/Prefabs/CellGUI.prefab         |   149 +
 .../MultipleMatches/Prefabs/CellGUI.prefab.meta    |    14 +
 .../MultipleMatches/Prefabs/MatchController.prefab |  2172 ++
 .../Prefabs/MatchController.prefab.meta            |    14 +
 .../MultipleMatches/Prefabs/MatchGUI.prefab        |   311 +
 .../MultipleMatches/Prefabs/MatchGUI.prefab.meta   |    14 +
 .../MultipleMatches/Prefabs/MatchPlayer.prefab     |    67 +
 .../Prefabs/MatchPlayer.prefab.meta                |    14 +
 .../MultipleMatches/Prefabs/PlayerGUI.prefab       |   185 +
 .../MultipleMatches/Prefabs/PlayerGUI.prefab.meta  |    14 +
 Assets/Mirror/Examples/MultipleMatches/README.md   |     9 +
 .../Mirror/Examples/MultipleMatches/README.md.meta |    14 +
 Assets/Mirror/Examples/MultipleMatches/Scenes.meta |     8 +
 .../Scenes/MirrorMultipleMatches.unity             |  2995 +++
 .../Scenes/MirrorMultipleMatches.unity.meta        |    14 +
 .../Mirror/Examples/MultipleMatches/Scripts.meta   |     8 +
 .../MultipleMatches/Scripts/CanvasController.cs    |   644 +
 .../Scripts/CanvasController.cs.meta               |    18 +
 .../Examples/MultipleMatches/Scripts/CellGUI.cs    |    47 +
 .../MultipleMatches/Scripts/CellGUI.cs.meta        |    18 +
 .../MultipleMatches/Scripts/MatchController.cs     |   312 +
 .../Scripts/MatchController.cs.meta                |    18 +
 .../Examples/MultipleMatches/Scripts/MatchGUI.cs   |    48 +
 .../MultipleMatches/Scripts/MatchGUI.cs.meta       |    18 +
 .../MultipleMatches/Scripts/MatchMessages.cs       |   117 +
 .../MultipleMatches/Scripts/MatchMessages.cs.meta  |    18 +
 .../MultipleMatches/Scripts/MatchNetworkManager.cs |   110 +
 .../Scripts/MatchNetworkManager.cs.meta            |    18 +
 .../Examples/MultipleMatches/Scripts/PlayerGUI.cs  |    17 +
 .../MultipleMatches/Scripts/PlayerGUI.cs.meta      |    18 +
 .../Examples/MultipleMatches/Scripts/RoomGUI.cs    |    45 +
 .../MultipleMatches/Scripts/RoomGUI.cs.meta        |    18 +
 Assets/Mirror/Examples/PickupsDropsChilds.meta     |     8 +
 .../Examples/PickupsDropsChilds/Materials.meta     |     8 +
 .../Examples/PickupsDropsChilds/Materials/Ball.mat |    78 +
 .../PickupsDropsChilds/Materials/Ball.mat.meta     |    15 +
 .../Examples/PickupsDropsChilds/Materials/Bat.mat  |    78 +
 .../PickupsDropsChilds/Materials/Bat.mat.meta      |    15 +
 .../Materials/Bouncy.physicMaterial                |    14 +
 .../Materials/Bouncy.physicMaterial.meta           |    15 +
 .../Examples/PickupsDropsChilds/Materials/Box.mat  |    78 +
 .../PickupsDropsChilds/Materials/Box.mat.meta      |    15 +
 .../PickupsDropsChilds/PickupsDropsChilds.unity    |   689 +
 .../PickupsDropsChilds.unity.meta                  |    14 +
 .../Examples/PickupsDropsChilds/Prefabs.meta       |     8 +
 .../PickupsDropsChilds/Prefabs/Ball.prefab         |   113 +
 .../PickupsDropsChilds/Prefabs/Ball.prefab.meta    |    14 +
 .../Examples/PickupsDropsChilds/Prefabs/Bat.prefab |   114 +
 .../PickupsDropsChilds/Prefabs/Bat.prefab.meta     |    14 +
 .../Examples/PickupsDropsChilds/Prefabs/Box.prefab |   113 +
 .../PickupsDropsChilds/Prefabs/Box.prefab.meta     |    14 +
 .../Prefabs/Custom Robot Kyle.prefab               |  1733 ++
 .../Prefabs/Custom Robot Kyle.prefab.meta          |    14 +
 .../PickupsDropsChilds/Prefabs/Player.prefab       |   202 +
 .../PickupsDropsChilds/Prefabs/Player.prefab.meta  |    14 +
 .../PickupsDropsChilds/Prefabs/SceneObject.prefab  |   130 +
 .../Prefabs/SceneObject.prefab.meta                |    14 +
 .../Examples/PickupsDropsChilds/Scripts.meta       |     8 +
 .../PickupsDropsChilds/Scripts/Enumerations.cs     |    10 +
 .../Scripts/Enumerations.cs.meta                   |    18 +
 .../PickupsDropsChilds/Scripts/Interfaces.meta     |     8 +
 .../Scripts/Interfaces/EquippedBall.cs             |    67 +
 .../Scripts/Interfaces/EquippedBall.cs.meta        |    18 +
 .../Scripts/Interfaces/EquippedBat.cs              |    67 +
 .../Scripts/Interfaces/EquippedBat.cs.meta         |    18 +
 .../Scripts/Interfaces/EquippedBox.cs              |    67 +
 .../Scripts/Interfaces/EquippedBox.cs.meta         |    18 +
 .../Scripts/Interfaces/IEquipped.cs                |    74 +
 .../Scripts/Interfaces/IEquipped.cs.meta           |    18 +
 .../Scripts/PickupsDropsChilds.cs                  |   259 +
 .../Scripts/PickupsDropsChilds.cs.meta             |    18 +
 .../PickupsDropsChilds/Scripts/SceneObject.cs      |   108 +
 .../PickupsDropsChilds/Scripts/SceneObject.cs.meta |    18 +
 Assets/Mirror/Examples/PlayerTest.meta             |     8 +
 .../Mirror/Examples/PlayerTest/PlayerHybrid.prefab |   491 +
 .../Examples/PlayerTest/PlayerHybrid.prefab.meta   |    14 +
 .../Examples/PlayerTest/PlayerRBHybrid.prefab      |   473 +
 .../Examples/PlayerTest/PlayerRBHybrid.prefab.meta |    14 +
 .../Examples/PlayerTest/PlayerRBReliable.prefab    |   474 +
 .../PlayerTest/PlayerRBReliable.prefab.meta        |    14 +
 .../Examples/PlayerTest/PlayerRBUnreliable.prefab  |   474 +
 .../PlayerTest/PlayerRBUnreliable.prefab.meta      |    14 +
 .../Examples/PlayerTest/PlayerReliable.prefab      |   492 +
 .../Examples/PlayerTest/PlayerReliable.prefab.meta |    14 +
 .../Mirror/Examples/PlayerTest/PlayerTestNetMan.cs |   265 +
 .../Examples/PlayerTest/PlayerTestNetMan.cs.meta   |    18 +
 .../Examples/PlayerTest/PlayerTestScene.meta       |     8 +
 .../Examples/PlayerTest/PlayerTestScene.unity      |   880 +
 .../Examples/PlayerTest/PlayerTestScene.unity.meta |    14 +
 .../PlayerTest/PlayerTestScene/LightingData.asset  |   Bin 0 -> 18360 bytes
 .../PlayerTestScene/LightingData.asset.meta        |    15 +
 .../PlayerTestScene/Lightmap-0_comp_dir.png        |   Bin 0 -> 308048 bytes
 .../PlayerTestScene/Lightmap-0_comp_dir.png.meta   |    99 +
 .../PlayerTestScene/Lightmap-0_comp_light.exr      |   Bin 0 -> 852415 bytes
 .../PlayerTestScene/Lightmap-0_comp_light.exr.meta |    99 +
 .../PlayerTestScene/ReflectionProbe-0.exr          |   Bin 0 -> 133554 bytes
 .../PlayerTestScene/ReflectionProbe-0.exr.meta     |    99 +
 .../PlayerTestScene/TerrainData2019.asset          |   Bin 0 -> 1952836 bytes
 .../PlayerTestScene/TerrainData2019.asset.meta     |    15 +
 .../PlayerTestScene/TerrainLayer2019.terrainlayer  |    22 +
 .../TerrainLayer2019.terrainlayer.meta             |    15 +
 .../Examples/PlayerTest/PlayerUnreliable.prefab    |   492 +
 .../PlayerTest/PlayerUnreliable.prefab.meta        |    14 +
 .../Mirror/Examples/PlayerTest/TankHybrid.prefab   |   657 +
 .../Examples/PlayerTest/TankHybrid.prefab.meta     |    14 +
 .../Mirror/Examples/PlayerTest/TankReliable.prefab |   660 +
 .../Examples/PlayerTest/TankReliable.prefab.meta   |    14 +
 .../Examples/PlayerTest/TankUnreliable.prefab      |   660 +
 .../Examples/PlayerTest/TankUnreliable.prefab.meta |    14 +
 Assets/Mirror/Examples/Pong.meta                   |     8 +
 Assets/Mirror/Examples/Pong/PhysicsMaterials.meta  |     8 +
 .../BallMaterial.physicsMaterial2D                 |    10 +
 .../BallMaterial.physicsMaterial2D.meta            |    15 +
 Assets/Mirror/Examples/Pong/Prefabs.meta           |     8 +
 Assets/Mirror/Examples/Pong/Prefabs/Ball.prefab    |   202 +
 .../Mirror/Examples/Pong/Prefabs/Ball.prefab.meta  |    15 +
 Assets/Mirror/Examples/Pong/Prefabs/Racket.prefab  |   202 +
 .../Examples/Pong/Prefabs/Racket.prefab.meta       |    15 +
 Assets/Mirror/Examples/Pong/Scenes.meta            |     8 +
 .../Mirror/Examples/Pong/Scenes/MirrorPong.unity   |   932 +
 .../Examples/Pong/Scenes/MirrorPong.unity.meta     |    15 +
 Assets/Mirror/Examples/Pong/Scripts.meta           |     8 +
 Assets/Mirror/Examples/Pong/Scripts/Ball.cs        |    69 +
 Assets/Mirror/Examples/Pong/Scripts/Ball.cs.meta   |    19 +
 .../Examples/Pong/Scripts/NetworkManagerPong.cs    |    45 +
 .../Pong/Scripts/NetworkManagerPong.cs.meta        |    18 +
 Assets/Mirror/Examples/Pong/Scripts/Player.cs      |    23 +
 Assets/Mirror/Examples/Pong/Scripts/Player.cs.meta |    19 +
 Assets/Mirror/Examples/Pong/Sprites.meta           |     8 +
 Assets/Mirror/Examples/Pong/Sprites/Ball.png       |   Bin 0 -> 2791 bytes
 Assets/Mirror/Examples/Pong/Sprites/Ball.png.meta  |    95 +
 Assets/Mirror/Examples/Pong/Sprites/DottedLine.png |   Bin 0 -> 2799 bytes
 .../Examples/Pong/Sprites/DottedLine.png.meta      |    95 +
 Assets/Mirror/Examples/Pong/Sprites/Racket.png     |   Bin 0 -> 2800 bytes
 .../Mirror/Examples/Pong/Sprites/Racket.png.meta   |    95 +
 .../Examples/Pong/Sprites/WallHorizontal.png       |   Bin 0 -> 2796 bytes
 .../Examples/Pong/Sprites/WallHorizontal.png.meta  |    95 +
 .../Mirror/Examples/Pong/Sprites/WallVertical.png  |   Bin 0 -> 2800 bytes
 .../Examples/Pong/Sprites/WallVertical.png.meta    |    95 +
 Assets/Mirror/Examples/RigidbodyBenchmark.meta     |     8 +
 .../Examples/RigidbodyBenchmark/Materials.meta     |     8 +
 .../RigidbodyBenchmark/Materials/Floor.mat         |    80 +
 .../RigidbodyBenchmark/Materials/Floor.mat.meta    |    15 +
 .../RigidbodyBenchmark/Materials/Player.mat        |    80 +
 .../RigidbodyBenchmark/Materials/Player.mat.meta   |    15 +
 .../RigidbodyBenchmark/Materials/Server.mat        |    80 +
 .../RigidbodyBenchmark/Materials/Server.mat.meta   |    15 +
 .../RigidbodyBenchmark/PhysicMaterials.meta        |     8 +
 .../PhysicMaterials/Ball.physicMaterial            |    14 +
 .../PhysicMaterials/Ball.physicMaterial.meta       |    15 +
 .../PhysicMaterials/Floor.physicMaterial           |    14 +
 .../PhysicMaterials/Floor.physicMaterial.meta      |    15 +
 .../Examples/RigidbodyBenchmark/Prefabs.meta       |     8 +
 .../RigidbodyBenchmark/Prefabs/Player Ball.prefab  |   182 +
 .../Prefabs/Player Ball.prefab.meta                |    14 +
 .../RigidbodyBenchmark/Prefabs/Server Ball.prefab  |   183 +
 .../Prefabs/Server Ball.prefab.meta                |    14 +
 .../Mirror/Examples/RigidbodyBenchmark/Scenes.meta |     8 +
 .../Scenes/MirrorRigidbodyBenchmark.unity          |   606 +
 .../Scenes/MirrorRigidbodyBenchmark.unity.meta     |    14 +
 .../Examples/RigidbodyBenchmark/Scripts.meta       |     8 +
 .../RigidbodyBenchmark/Scripts/AddForce.cs         |    27 +
 .../RigidbodyBenchmark/Scripts/AddForce.cs.meta    |    18 +
 .../RigidbodyBenchmark/Scripts/AutoForce.cs        |    32 +
 .../RigidbodyBenchmark/Scripts/AutoForce.cs.meta   |    18 +
 .../Scripts/RigidbodyBenchmarkNetworkManager.cs    |    52 +
 .../RigidbodyBenchmarkNetworkManager.cs.meta       |    18 +
 Assets/Mirror/Examples/RigidbodyPhysics.meta       |     8 +
 .../Examples/RigidbodyPhysics/Materials.meta       |     8 +
 .../Examples/RigidbodyPhysics/Materials/Floor.mat  |    80 +
 .../RigidbodyPhysics/Materials/Floor.mat.meta      |    15 +
 .../Examples/RigidbodyPhysics/Materials/Player.mat |    80 +
 .../RigidbodyPhysics/Materials/Player.mat.meta     |    15 +
 .../Examples/RigidbodyPhysics/Materials/Server.mat |    80 +
 .../RigidbodyPhysics/Materials/Server.mat.meta     |    15 +
 .../Examples/RigidbodyPhysics/PhysicMaterials.meta |     8 +
 .../PhysicMaterials/Ball.physicMaterial            |    14 +
 .../PhysicMaterials/Ball.physicMaterial.meta       |    15 +
 .../PhysicMaterials/Floor.physicMaterial           |    14 +
 .../PhysicMaterials/Floor.physicMaterial.meta      |    15 +
 .../Mirror/Examples/RigidbodyPhysics/Prefabs.meta  |     8 +
 .../RigidbodyPhysics/Prefabs/Player Ball.prefab    |   182 +
 .../Prefabs/Player Ball.prefab.meta                |    14 +
 .../Mirror/Examples/RigidbodyPhysics/Scenes.meta   |     8 +
 .../Scenes/MirrorBounceScene.unity                 |  1378 ++
 .../Scenes/MirrorBounceScene.unity.meta            |    14 +
 .../Mirror/Examples/RigidbodyPhysics/Scripts.meta  |     8 +
 .../Examples/RigidbodyPhysics/Scripts/AddForce.cs  |    27 +
 .../RigidbodyPhysics/Scripts/AddForce.cs.meta      |    18 +
 Assets/Mirror/Examples/Room.meta                   |     8 +
 Assets/Mirror/Examples/Room/Materials.meta         |     8 +
 Assets/Mirror/Examples/Room/Materials/PlayArea.mat |    77 +
 .../Examples/Room/Materials/PlayArea.mat.meta      |    15 +
 Assets/Mirror/Examples/Room/Materials/Player.mat   |    77 +
 .../Mirror/Examples/Room/Materials/Player.mat.meta |    15 +
 Assets/Mirror/Examples/Room/Materials/Prize.mat    |    77 +
 .../Mirror/Examples/Room/Materials/Prize.mat.meta  |    15 +
 Assets/Mirror/Examples/Room/Prefabs.meta           |     8 +
 .../Room/Prefabs/GamePlayerReliable.prefab         |   403 +
 .../Room/Prefabs/GamePlayerReliable.prefab.meta    |    15 +
 .../Room/Prefabs/GamePlayerUnreliable.prefab       |   403 +
 .../Room/Prefabs/GamePlayerUnreliable.prefab.meta  |    15 +
 Assets/Mirror/Examples/Room/Prefabs/Reward.prefab  |   198 +
 .../Examples/Room/Prefabs/Reward.prefab.meta       |    15 +
 .../Mirror/Examples/Room/Prefabs/RoomPlayer.prefab |    69 +
 .../Examples/Room/Prefabs/RoomPlayer.prefab.meta   |    15 +
 Assets/Mirror/Examples/Room/README.md              |    28 +
 Assets/Mirror/Examples/Room/README.md.meta         |    14 +
 Assets/Mirror/Examples/Room/Scenes.meta            |     8 +
 .../Examples/Room/Scenes/MirrorRoomGame.meta       |     8 +
 .../Examples/Room/Scenes/MirrorRoomGame.unity      |   888 +
 .../Examples/Room/Scenes/MirrorRoomGame.unity.meta |    14 +
 .../Room/Scenes/MirrorRoomGame/LightingData.asset  |   Bin 0 -> 18160 bytes
 .../Scenes/MirrorRoomGame/LightingData.asset.meta  |    15 +
 .../Scenes/MirrorRoomGame/ReflectionProbe-0.exr    |   Bin 0 -> 110488 bytes
 .../MirrorRoomGame/ReflectionProbe-0.exr.meta      |    99 +
 .../Examples/Room/Scenes/MirrorRoomOffline.unity   |   330 +
 .../Room/Scenes/MirrorRoomOffline.unity.meta       |    14 +
 .../Examples/Room/Scenes/MirrorRoomOnline.unity    |   198 +
 .../Room/Scenes/MirrorRoomOnline.unity.meta        |    14 +
 Assets/Mirror/Examples/Room/Scripts.meta           |     8 +
 .../Examples/Room/Scripts/NetworkRoomManagerExt.cs |   110 +
 .../Room/Scripts/NetworkRoomManagerExt.cs.meta     |    18 +
 .../Examples/Room/Scripts/NetworkRoomPlayerExt.cs  |    38 +
 .../Room/Scripts/NetworkRoomPlayerExt.cs.meta      |    18 +
 Assets/Mirror/Examples/Room/Scripts/PlayerScore.cs |    19 +
 .../Examples/Room/Scripts/PlayerScore.cs.meta      |    18 +
 Assets/Mirror/Examples/Room/Scripts/Reward.cs      |    65 +
 Assets/Mirror/Examples/Room/Scripts/Reward.cs.meta |    18 +
 Assets/Mirror/Examples/Room/Scripts/Spawner.cs     |   104 +
 .../Mirror/Examples/Room/Scripts/Spawner.cs.meta   |    18 +
 Assets/Mirror/Examples/Snapshot Interpolation.meta |     8 +
 .../Examples/Snapshot Interpolation/ClientCube.cs  |   221 +
 .../Snapshot Interpolation/ClientCube.cs.meta      |    10 +
 .../Snapshot Interpolation/ClientMaterial.mat      |    80 +
 .../Snapshot Interpolation/ClientMaterial.mat.meta |    15 +
 .../MirrorSnapshotInterpolation.unity              |   447 +
 .../MirrorSnapshotInterpolation.unity.meta         |    14 +
 .../Examples/Snapshot Interpolation/README.txt     |     3 +
 .../Snapshot Interpolation/README.txt.meta         |    10 +
 .../Examples/Snapshot Interpolation/ServerCube.cs  |   108 +
 .../Snapshot Interpolation/ServerCube.cs.meta      |    18 +
 .../Snapshot Interpolation/ServerMaterial.mat      |    80 +
 .../Snapshot Interpolation/ServerMaterial.mat.meta |    15 +
 .../Examples/Snapshot Interpolation/Snapshot3D.cs  |    26 +
 .../Snapshot Interpolation/Snapshot3D.cs.meta      |    18 +
 .../Snapshot Interpolation/_DISABLE VSYNC_         |     2 +
 .../Snapshot Interpolation/_DISABLE VSYNC_.meta    |    14 +
 Assets/Mirror/Examples/StackedPrediction.meta      |     8 +
 .../Examples/StackedPrediction/CubeMaterial.mat    |    81 +
 .../StackedPrediction/CubeMaterial.mat.meta        |    15 +
 .../StackedPrediction/CubeMaterial.physicMaterial  |    14 +
 .../CubeMaterial.physicMaterial.meta               |    15 +
 .../Examples/StackedPrediction/GroundMaterial.mat  |    82 +
 .../StackedPrediction/GroundMaterial.mat.meta      |    15 +
 .../MirrorStackedPrediction.unity                  |   554 +
 .../MirrorStackedPrediction.unity.meta             |    14 +
 .../NetworkManagerStackedPrediction.cs             |    83 +
 .../NetworkManagerStackedPrediction.cs.meta        |    18 +
 .../Examples/StackedPrediction/PlayerForce.cs      |    47 +
 .../Examples/StackedPrediction/PlayerForce.cs.meta |    10 +
 .../StackedPrediction/PlayerSpectator.prefab       |    67 +
 .../StackedPrediction/PlayerSpectator.prefab.meta  |    14 +
 .../StackedPrediction/PredictedCube.prefab         |   168 +
 .../StackedPrediction/PredictedCube.prefab.meta    |    14 +
 .../Mirror/Examples/StackedPrediction/_Readme.txt  |    17 +
 .../Examples/StackedPrediction/_Readme.txt.meta    |    10 +
 Assets/Mirror/Examples/SyncDirection.meta          |     8 +
 .../SyncDirection/MirrorSyncDirection.unity        |   618 +
 .../SyncDirection/MirrorSyncDirection.unity.meta   |    14 +
 Assets/Mirror/Examples/SyncDirection/Player.cs     |    58 +
 .../Mirror/Examples/SyncDirection/Player.cs.meta   |    18 +
 Assets/Mirror/Examples/SyncDirection/Player.prefab |   212 +
 .../Examples/SyncDirection/Player.prefab.meta      |    14 +
 Assets/Mirror/Examples/SyncDirection/White.mat     |    77 +
 .../Mirror/Examples/SyncDirection/White.mat.meta   |    15 +
 Assets/Mirror/Examples/TankTheftAuto.meta          |     8 +
 .../Mirror/Examples/TankTheftAuto/Materials.meta   |     8 +
 .../TankTheftAuto/Materials/MaterialPlayer.mat     |    77 +
 .../Materials/MaterialPlayer.mat.meta              |    15 +
 .../TankTheftAuto/Materials/MaterialTrigger.mat    |    78 +
 .../Materials/MaterialTrigger.mat.meta             |    15 +
 .../TankTheftAuto/MirrorTankTheftAuto.meta         |     8 +
 .../TankTheftAuto/MirrorTankTheftAuto.unity        |   982 +
 .../TankTheftAuto/MirrorTankTheftAuto.unity.meta   |    14 +
 .../MirrorTankTheftAuto/LightingData.asset         |   Bin 0 -> 18136 bytes
 .../MirrorTankTheftAuto/LightingData.asset.meta    |    15 +
 Assets/Mirror/Examples/TankTheftAuto/Prefabs.meta  |     8 +
 .../TankTheftAuto/Prefabs/PlayerReliable.prefab    |   385 +
 .../Prefabs/PlayerReliable.prefab.meta             |    14 +
 .../TankTheftAuto/Prefabs/PlayerUnreliable.prefab  |   385 +
 .../Prefabs/PlayerUnreliable.prefab.meta           |    14 +
 .../TankTheftAuto/Prefabs/TankReliable.prefab      |   886 +
 .../TankTheftAuto/Prefabs/TankReliable.prefab.meta |    14 +
 .../TankTheftAuto/Prefabs/TankUnreliable.prefab    |   886 +
 .../Prefabs/TankUnreliable.prefab.meta             |    14 +
 Assets/Mirror/Examples/TankTheftAuto/Scripts.meta  |     8 +
 .../TankTheftAuto/Scripts/TankAuthority.cs         |   143 +
 .../TankTheftAuto/Scripts/TankAuthority.cs.meta    |    18 +
 .../TankTheftAuto/Scripts/TankTheftAutoNetMan.cs   |    30 +
 .../Scripts/TankTheftAutoNetMan.cs.meta            |    18 +
 Assets/Mirror/Examples/Tanks.meta                  |     8 +
 Assets/Mirror/Examples/Tanks/Prefabs.meta          |     8 +
 .../Examples/Tanks/Prefabs/Projectile.prefab       |   181 +
 .../Examples/Tanks/Prefabs/Projectile.prefab.meta  |    14 +
 Assets/Mirror/Examples/Tanks/Prefabs/Tank.prefab   |   363 +
 .../Mirror/Examples/Tanks/Prefabs/Tank.prefab.meta |    15 +
 Assets/Mirror/Examples/Tanks/Readme.txt            |     2 +
 Assets/Mirror/Examples/Tanks/Readme.txt.meta       |    10 +
 Assets/Mirror/Examples/Tanks/Scenes.meta           |     8 +
 .../Mirror/Examples/Tanks/Scenes/MirrorTanks.meta  |     8 +
 .../Mirror/Examples/Tanks/Scenes/MirrorTanks.unity |   713 +
 .../Examples/Tanks/Scenes/MirrorTanks.unity.meta   |    14 +
 .../Tanks/Scenes/MirrorTanks/NavMesh.asset         |   Bin 0 -> 6564 bytes
 .../Tanks/Scenes/MirrorTanks/NavMesh.asset.meta    |    15 +
 Assets/Mirror/Examples/Tanks/Scripts.meta          |     8 +
 Assets/Mirror/Examples/Tanks/Scripts/Box.cs        |    94 +
 Assets/Mirror/Examples/Tanks/Scripts/Box.cs.meta   |    18 +
 Assets/Mirror/Examples/Tanks/Scripts/Projectile.cs |    46 +
 .../Examples/Tanks/Scripts/Projectile.cs.meta      |    18 +
 Assets/Mirror/Examples/Tanks/Scripts/Tank.cs       |   106 +
 Assets/Mirror/Examples/Tanks/Scripts/Tank.cs.meta  |    18 +
 Assets/Mirror/Examples/TopDownShooter.meta         |     8 +
 .../Mirror/Examples/TopDownShooter/Materials.meta  |     8 +
 .../TopDownShooter/Materials/DeathSplatter.mat     |    78 +
 .../Materials/DeathSplatter.mat.meta               |    15 +
 .../Examples/TopDownShooter/Materials/Enemy.mat    |    78 +
 .../TopDownShooter/Materials/Enemy.mat.meta        |    15 +
 .../TopDownShooter/Materials/EnemyHand1.mat        |    78 +
 .../TopDownShooter/Materials/EnemyHand1.mat.meta   |    15 +
 .../TopDownShooter/Materials/EnemyHand2.mat        |    78 +
 .../TopDownShooter/Materials/EnemyHand2.mat.meta   |    15 +
 .../Examples/TopDownShooter/Materials/Flash.mat    |    78 +
 .../TopDownShooter/Materials/Flash.mat.meta        |    15 +
 .../Examples/TopDownShooter/Materials/Floor.mat    |    83 +
 .../TopDownShooter/Materials/Floor.mat.meta        |    15 +
 .../Examples/TopDownShooter/Materials/HitPoint.mat |    78 +
 .../TopDownShooter/Materials/HitPoint.mat.meta     |    15 +
 .../TopDownShooter/Materials/MaterialBlack.mat     |    83 +
 .../Materials/MaterialBlack.mat.meta               |    15 +
 .../TopDownShooter/Materials/MaterialGrey.mat      |    83 +
 .../TopDownShooter/Materials/MaterialGrey.mat.meta |    15 +
 .../TopDownShooter/Materials/MaterialWalls.mat     |    77 +
 .../Materials/MaterialWalls.mat.meta               |    15 +
 .../TopDownShooter/Materials/MaterialYellow.mat    |    83 +
 .../Materials/MaterialYellow.mat.meta              |    15 +
 .../Examples/TopDownShooter/Materials/Player.mat   |    78 +
 .../TopDownShooter/Materials/Player.mat.meta       |    15 +
 .../Examples/TopDownShooter/Materials/PlayerLF.mat |    78 +
 .../TopDownShooter/Materials/PlayerLF.mat.meta     |    15 +
 .../Examples/TopDownShooter/Materials/PlayerRF.mat |    78 +
 .../TopDownShooter/Materials/PlayerRF.mat.meta     |    15 +
 .../TopDownShooter/Materials/RespawnPortal.mat     |    78 +
 .../Materials/RespawnPortal.mat.meta               |    15 +
 Assets/Mirror/Examples/TopDownShooter/Prefabs.meta |     8 +
 .../TopDownShooter/Prefabs/DeathSplatter.prefab    |   240 +
 .../Prefabs/DeathSplatter.prefab.meta              |    14 +
 .../TopDownShooter/Prefabs/EnemyPrefab.prefab      |   928 +
 .../TopDownShooter/Prefabs/EnemyPrefab.prefab.meta |    14 +
 .../TopDownShooter/Prefabs/PlayerPrefab.prefab     |  2066 ++
 .../Prefabs/PlayerPrefab.prefab.meta               |    14 +
 Assets/Mirror/Examples/TopDownShooter/Scenes.meta  |     8 +
 .../Scenes/MirrorTopDownShooter.meta               |     8 +
 .../Scenes/MirrorTopDownShooter.unity              |  5435 +++++
 .../Scenes/MirrorTopDownShooter.unity.meta         |    14 +
 .../Scenes/MirrorTopDownShooter/LightingData.asset |   Bin 0 -> 18160 bytes
 .../MirrorTopDownShooter/LightingData.asset.meta   |    15 +
 .../Scenes/MirrorTopDownShooter/NavMesh.asset      |   Bin 0 -> 9348 bytes
 .../Scenes/MirrorTopDownShooter/NavMesh.asset.meta |    15 +
 .../MirrorTopDownShooter/ReflectionProbe-0.exr     |   Bin 0 -> 138601 bytes
 .../ReflectionProbe-0.exr.meta                     |    99 +
 Assets/Mirror/Examples/TopDownShooter/Scripts.meta |     8 +
 .../TopDownShooter/Scripts/CameraTopDown.cs        |    22 +
 .../TopDownShooter/Scripts/CameraTopDown.cs.meta   |    18 +
 .../Examples/TopDownShooter/Scripts/CanvasHUD.cs   |   224 +
 .../TopDownShooter/Scripts/CanvasHUD.cs.meta       |    18 +
 .../TopDownShooter/Scripts/CanvasTopDown.cs        |    97 +
 .../TopDownShooter/Scripts/CanvasTopDown.cs.meta   |    18 +
 .../TopDownShooter/Scripts/EnemyTopDown.cs         |   183 +
 .../TopDownShooter/Scripts/EnemyTopDown.cs.meta    |    18 +
 .../TopDownShooter/Scripts/NetworkTopDown.cs       |    66 +
 .../TopDownShooter/Scripts/NetworkTopDown.cs.meta  |    18 +
 .../TopDownShooter/Scripts/PlayerTopDown.cs        |   338 +
 .../TopDownShooter/Scripts/PlayerTopDown.cs.meta   |    18 +
 .../TopDownShooter/Scripts/RespawnPortal.cs        |    52 +
 .../TopDownShooter/Scripts/RespawnPortal.cs.meta   |    18 +
 .../Mirror/Examples/TopDownShooter/Textures.meta   |     8 +
 .../Examples/TopDownShooter/Textures/CornerUI.png  |   Bin 0 -> 18986 bytes
 .../TopDownShooter/Textures/CornerUI.png.meta      |   160 +
 .../TopDownShooter/Textures/DeathSplatter.png      |   Bin 0 -> 80253 bytes
 .../TopDownShooter/Textures/DeathSplatter.png.meta |   160 +
 .../Examples/TopDownShooter/Textures/Enemy.png     |   Bin 0 -> 104644 bytes
 .../TopDownShooter/Textures/Enemy.png.meta         |   160 +
 .../TopDownShooter/Textures/EnemyHand1.png         |   Bin 0 -> 29523 bytes
 .../TopDownShooter/Textures/EnemyHand1.png.meta    |   160 +
 .../TopDownShooter/Textures/EnemyHand2.png         |   Bin 0 -> 30621 bytes
 .../TopDownShooter/Textures/EnemyHand2.png.meta    |   160 +
 .../Examples/TopDownShooter/Textures/Flash.png     |   Bin 0 -> 40613 bytes
 .../TopDownShooter/Textures/Flash.png.meta         |   160 +
 .../Examples/TopDownShooter/Textures/Floor.jpg     |   Bin 0 -> 25987 bytes
 .../TopDownShooter/Textures/Floor.jpg.meta         |   160 +
 .../Examples/TopDownShooter/Textures/HitPoint.png  |   Bin 0 -> 107018 bytes
 .../TopDownShooter/Textures/HitPoint.png.meta      |   160 +
 .../Examples/TopDownShooter/Textures/Player.png    |   Bin 0 -> 55932 bytes
 .../TopDownShooter/Textures/Player.png.meta        |   160 +
 .../TopDownShooter/Textures/PlayerFootLeft.png     |   Bin 0 -> 12187 bytes
 .../Textures/PlayerFootLeft.png.meta               |   160 +
 .../TopDownShooter/Textures/PlayerFootRight.png    |   Bin 0 -> 12136 bytes
 .../Textures/PlayerFootRight.png.meta              |   160 +
 .../TopDownShooter/Textures/RespawnPortal.png      |   Bin 0 -> 196907 bytes
 .../TopDownShooter/Textures/RespawnPortal.png.meta |   160 +
 Assets/Mirror/Examples/VR.meta                     |     8 +
 Assets/Mirror/Examples/VR/Readme.txt               |     5 +
 Assets/Mirror/Examples/VR/Readme.txt.meta          |    10 +
 Assets/Mirror/Examples/_Common.meta                |     8 +
 Assets/Mirror/Examples/_Common/Controllers.meta    |     8 +
 .../_Common/Controllers/ControllerUIBase.cs        |   180 +
 .../_Common/Controllers/ControllerUIBase.cs.meta   |    18 +
 .../_Common/Controllers/FlyerController.meta       |     8 +
 .../FlyerController/FlyerControllerBase.cs         |   575 +
 .../FlyerController/FlyerControllerBase.cs.meta    |    18 +
 .../FlyerController/FlyerControllerReliable.cs     |     8 +
 .../FlyerControllerReliable.cs.meta                |    18 +
 .../FlyerController/FlyerControllerUI.cs           |    67 +
 .../FlyerController/FlyerControllerUI.cs.meta      |    18 +
 .../FlyerController/FlyerControllerUI.prefab       |  4109 ++++
 .../FlyerController/FlyerControllerUI.prefab.meta  |    14 +
 .../FlyerController/FlyerControllerUnreliable.cs   |     8 +
 .../FlyerControllerUnreliable.cs.meta              |    18 +
 .../_Common/Controllers/PlayerController.meta      |     8 +
 .../PlayerController/PlayerControllerBase.cs       |   477 +
 .../PlayerController/PlayerControllerBase.cs.meta  |    18 +
 .../PlayerController/PlayerControllerHybrid.cs     |     8 +
 .../PlayerControllerHybrid.cs.meta                 |    18 +
 .../PlayerController/PlayerControllerReliable.cs   |     8 +
 .../PlayerControllerReliable.cs.meta               |    18 +
 .../PlayerController/PlayerControllerUI.cs         |    51 +
 .../PlayerController/PlayerControllerUI.cs.meta    |    18 +
 .../PlayerController/PlayerControllerUI.prefab     |  2740 +++
 .../PlayerControllerUI.prefab.meta                 |    14 +
 .../PlayerController/PlayerControllerUnreliable.cs |     8 +
 .../PlayerControllerUnreliable.cs.meta             |    18 +
 .../_Common/Controllers/PlayerControllerRB.meta    |     8 +
 .../PlayerControllerRB/PlayerControllerRBBase.cs   |   511 +
 .../PlayerControllerRBBase.cs.meta                 |    18 +
 .../PlayerControllerRB/PlayerControllerRBHybrid.cs |    23 +
 .../PlayerControllerRBHybrid.cs.meta               |    18 +
 .../PlayerControllerRBReliable.cs                  |    23 +
 .../PlayerControllerRBReliable.cs.meta             |    18 +
 .../PlayerControllerRB/PlayerControllerRBUI.cs     |    51 +
 .../PlayerControllerRBUI.cs.meta                   |    18 +
 .../PlayerControllerRB/PlayerControllerRBUI.prefab |  2740 +++
 .../PlayerControllerRBUI.prefab.meta               |    14 +
 .../PlayerControllerRBUnreliable.cs                |    23 +
 .../PlayerControllerRBUnreliable.cs.meta           |    18 +
 .../_Common/Controllers/TankController.meta        |     8 +
 .../TankController/TankControllerBase.cs           |   336 +
 .../TankController/TankControllerBase.cs.meta      |    18 +
 .../TankController/TankControllerHybrid.cs         |     8 +
 .../TankController/TankControllerHybrid.cs.meta    |    18 +
 .../TankController/TankControllerReliable.cs       |     8 +
 .../TankController/TankControllerReliable.cs.meta  |    18 +
 .../Controllers/TankController/TankControllerUI.cs |    54 +
 .../TankController/TankControllerUI.cs.meta        |    18 +
 .../TankController/TankControllerUI.prefab         |  2272 ++
 .../TankController/TankControllerUI.prefab.meta    |    14 +
 .../TankController/TankControllerUnreliable.cs     |     8 +
 .../TankControllerUnreliable.cs.meta               |    18 +
 .../Controllers/TankController/TankHealth.cs       |    83 +
 .../Controllers/TankController/TankHealth.cs.meta  |    18 +
 .../Controllers/TankController/TankTurretBase.cs   |   468 +
 .../TankController/TankTurretBase.cs.meta          |    18 +
 .../Controllers/TankController/TankTurretHybrid.cs |    60 +
 .../TankController/TankTurretHybrid.cs.meta        |    18 +
 .../TankController/TankTurretReliable.cs           |    60 +
 .../TankController/TankTurretReliable.cs.meta      |    18 +
 .../TankController/TankTurretUnreliable.cs         |    60 +
 .../TankController/TankTurretUnreliable.cs.meta    |    18 +
 .../_Common/Controllers/TankController/TurretUI.cs |    31 +
 .../Controllers/TankController/TurretUI.cs.meta    |    18 +
 .../Controllers/TankController/TurretUI.prefab     |  1527 ++
 .../TankController/TurretUI.prefab.meta            |    14 +
 Assets/Mirror/Examples/_Common/KenneyAssets.meta   |     8 +
 .../_Common/KenneyAssets/kenney_kenney-fonts.meta  |     8 +
 .../KenneyAssets/kenney_kenney-fonts/Fonts.meta    |     8 +
 .../kenney_kenney-fonts/Fonts/Kenney Mini.ttf      |   Bin 0 -> 26156 bytes
 .../kenney_kenney-fonts/Fonts/Kenney Mini.ttf.meta |    29 +
 .../KenneyAssets/kenney_kenney-fonts/License.txt   |    22 +
 .../kenney_kenney-fonts/License.txt.meta           |    14 +
 .../_Common/KenneyAssets/kenney_rpg-audio.meta     |     8 +
 .../KenneyAssets/kenney_rpg-audio/Audio.meta       |     8 +
 .../kenney_rpg-audio/Audio/footstep06.ogg          |   Bin 0 -> 9885 bytes
 .../kenney_rpg-audio/Audio/footstep06.ogg.meta     |    30 +
 .../kenney_rpg-audio/Audio/footstep09.ogg          |   Bin 0 -> 9356 bytes
 .../kenney_rpg-audio/Audio/footstep09.ogg.meta     |    30 +
 .../KenneyAssets/kenney_rpg-audio/License.txt      |    21 +
 .../KenneyAssets/kenney_rpg-audio/License.txt.meta |    14 +
 Assets/Mirror/Examples/_Common/OpenGameArt.meta    |     8 +
 .../Examples/_Common/OpenGameArt/License.txt       |     6 +
 .../Examples/_Common/OpenGameArt/License.txt.meta  |    14 +
 .../Examples/_Common/OpenGameArt/Sounds.meta       |     8 +
 .../OpenGameArt/Sounds/05._damage_grunt_male.mp3   |   Bin 0 -> 4241 bytes
 .../Sounds/05._damage_grunt_male.mp3.meta          |    30 +
 .../OpenGameArt/Sounds/8bit_gunloop_explosion.mp3  |   Bin 0 -> 1913 bytes
 .../Sounds/8bit_gunloop_explosion.mp3.meta         |    30 +
 .../Sounds/Light Switch Click On Sfx.mp3           |   Bin 0 -> 2004 bytes
 .../Sounds/Light Switch Click On Sfx.mp3.meta      |    31 +
 .../Sounds/The Good Fight (just intro).mp3         |   Bin 0 -> 27452 bytes
 .../Sounds/The Good Fight (just intro).mp3.meta    |    31 +
 .../Sounds/The Good Fight (no intro).mp3           |   Bin 0 -> 374246 bytes
 .../Sounds/The Good Fight (no intro).mp3.meta      |    31 +
 .../OpenGameArt/Sounds/hjm-tesla_sound_shot.mp3    |   Bin 0 -> 4590 bytes
 .../Sounds/hjm-tesla_sound_shot.mp3.meta           |    30 +
 .../_Common/OpenGameArt/Sounds/impactsplat03.mp3   |   Bin 0 -> 6755 bytes
 .../OpenGameArt/Sounds/impactsplat03.mp3.meta      |    30 +
 .../_Common/OpenGameArt/Sounds/mutantdie.mp3       |   Bin 0 -> 6971 bytes
 .../_Common/OpenGameArt/Sounds/mutantdie.mp3.meta  |    30 +
 .../_Common/OpenGameArt/Sounds/vgmenuhighlight.mp3 |   Bin 0 -> 1458 bytes
 .../OpenGameArt/Sounds/vgmenuhighlight.mp3.meta    |    30 +
 .../_Common/OpenGameArt/Sounds/wolf_monster.mp3    |   Bin 0 -> 13942 bytes
 .../OpenGameArt/Sounds/wolf_monster.mp3.meta       |    30 +
 Assets/Mirror/Examples/_Common/Projectiles.meta    |     8 +
 .../_Common/Projectiles/TankProjectile.meta        |     8 +
 .../Projectiles/TankProjectile/TankProjectile.cs   |    58 +
 .../TankProjectile/TankProjectile.cs.meta          |    18 +
 .../Projectiles/TankProjectile/TankProjectile.mat  |    80 +
 .../TankProjectile/TankProjectile.mat.meta         |    15 +
 .../TankProjectile/TankProjectile.prefab           |   161 +
 .../TankProjectile/TankProjectile.prefab.meta      |    14 +
 Assets/Mirror/Examples/_Common/RobotKyle.meta      |     8 +
 .../Examples/_Common/RobotKyle/Materials.meta      |     7 +
 .../_Common/RobotKyle/Materials/Robot_Color.mat    |    93 +
 .../RobotKyle/Materials/Robot_Color.mat.meta       |    11 +
 .../Mirror/Examples/_Common/RobotKyle/Models.meta  |     7 +
 .../_Common/RobotKyle/Models/Robot Kyle.fbx        |   Bin 0 -> 330704 bytes
 .../_Common/RobotKyle/Models/Robot Kyle.fbx.meta   |   810 +
 .../Examples/_Common/RobotKyle/Robot Kyle.prefab   |  1702 ++
 .../_Common/RobotKyle/Robot Kyle.prefab.meta       |    14 +
 .../Examples/_Common/RobotKyle/Textures.meta       |     7 +
 .../_Common/RobotKyle/Textures/Robot_Color.jpeg    |   Bin 0 -> 494045 bytes
 .../RobotKyle/Textures/Robot_Color.jpeg.meta       |   111 +
 .../_Common/RobotKyle/Textures/Robot_Normal.jpeg   |   Bin 0 -> 441267 bytes
 .../RobotKyle/Textures/Robot_Normal.jpeg.meta      |   111 +
 Assets/Mirror/Examples/_Common/Scripts.meta        |     8 +
 .../_Common/Scripts/CanvasNetworkManagerHUD.meta   |     8 +
 .../CanvasNetworkManagerHUD.cs                     |   233 +
 .../CanvasNetworkManagerHUD.cs.meta                |    18 +
 .../CanvasNetworkManagerHUD.prefab                 |  1897 ++
 .../CanvasNetworkManagerHUD.prefab.meta            |    14 +
 Assets/Mirror/Examples/_Common/Scripts/FPS.cs      |    38 +
 Assets/Mirror/Examples/_Common/Scripts/FPS.cs.meta |    18 +
 .../Mirror/Examples/_Common/Scripts/FaceCamera.cs  |    15 +
 .../Examples/_Common/Scripts/FaceCamera.cs.meta    |    18 +
 .../Mirror/Examples/_Common/Scripts/PerlinNoise.cs |    52 +
 .../Examples/_Common/Scripts/PerlinNoise.cs.meta   |    18 +
 .../Examples/_Common/Scripts/PhysicsSimulator.meta |     8 +
 .../Scripts/PhysicsSimulator/PhysicsSimulator.cs   |    40 +
 .../PhysicsSimulator/PhysicsSimulator.cs.meta      |    18 +
 .../PhysicsSimulator/PhysicsSimulator.prefab       |    45 +
 .../PhysicsSimulator/PhysicsSimulator.prefab.meta  |    14 +
 .../Examples/_Common/Scripts/PlayerCamera.cs       |    77 +
 .../Examples/_Common/Scripts/PlayerCamera.cs.meta  |    18 +
 .../Mirror/Examples/_Common/Scripts/RandomColor.cs |    35 +
 .../Examples/_Common/Scripts/RandomColor.cs.meta   |    18 +
 Assets/Mirror/Examples/_Common/Scripts/Respawn.cs  |    47 +
 .../Examples/_Common/Scripts/Respawn.cs.meta       |    18 +
 Assets/Mirror/Examples/_Common/TankModel.meta      |     8 +
 .../TankModel/(Public Domain) Recon_Tank.meta      |     8 +
 .../(Public Domain) Recon_Tank/BaseColor.png       |   Bin 0 -> 939498 bytes
 .../(Public Domain) Recon_Tank/BaseColor.png.meta  |    95 +
 .../Controller.controller                          |   298 +
 .../Controller.controller.meta                     |    15 +
 .../(Public Domain) Recon_Tank/Emissive.png        |   Bin 0 -> 80294 bytes
 .../(Public Domain) Recon_Tank/Emissive.png.meta   |    95 +
 .../(Public Domain) Recon_Tank/Metallic.png        |   Bin 0 -> 62860 bytes
 .../(Public Domain) Recon_Tank/Metallic.png.meta   |    95 +
 .../(Public Domain) Recon_Tank/Normal.png          |   Bin 0 -> 666342 bytes
 .../(Public Domain) Recon_Tank/Normal.png.meta     |    95 +
 .../Recon_Tank - License.txt                       |     7 +
 .../Recon_Tank - License.txt.meta                  |    15 +
 .../(Public Domain) Recon_Tank/TankMaterial.mat    |    82 +
 .../TankMaterial.mat.meta                          |    15 +
 .../(Public Domain) Recon_Tank/reconTank.fbx       |   Bin 0 -> 224204 bytes
 .../(Public Domain) Recon_Tank/reconTank.fbx.meta  |   340 +
 .../Examples/_Common/TankModel/BasePrefab.prefab   |   395 +
 .../_Common/TankModel/BasePrefab.prefab.meta       |    14 +
 Assets/Mirror/Examples/_Common/Textures.meta       |     8 +
 .../(Public Domain) Dirt Hand Painted Texture.meta |     8 +
 .../Dirt Hand Painted Texture - License.txt        |     5 +
 .../Dirt Hand Painted Texture - License.txt.meta   |    15 +
 .../Dirt.mat                                       |    82 +
 .../Dirt.mat.meta                                  |    16 +
 .../dirt.png                                       |   Bin 0 -> 105829 bytes
 .../dirt.png.meta                                  |    96 +
 Assets/Mirror/Examples/_Common/Textures/Wall01.jpg |   Bin 0 -> 60894 bytes
 .../Examples/_Common/Textures/Wall01.jpg.meta      |    99 +
 .../Mirror/Examples/_Common/Textures/Wall01_n.jpg  |   Bin 0 -> 33321 bytes
 .../Examples/_Common/Textures/Wall01_n.jpg.meta    |    99 +
 Assets/Mirror/Hosting.meta                         |     8 +
 Assets/Mirror/Hosting/Edgegap.meta                 |     8 +
 Assets/Mirror/Hosting/Edgegap/CHANGELOG.md         |     3 +
 Assets/Mirror/Hosting/Edgegap/CHANGELOG.md.meta    |    14 +
 Assets/Mirror/Hosting/Edgegap/Dependencies.meta    |     8 +
 .../Hosting/Edgegap/Dependencies/HttpEncoder.cs    |   704 +
 .../Edgegap/Dependencies/HttpEncoder.cs.meta       |    10 +
 .../Hosting/Edgegap/Dependencies/HttpUtility.cs    |   230 +
 .../Edgegap/Dependencies/HttpUtility.cs.meta       |    10 +
 Assets/Mirror/Hosting/Edgegap/Edgegap.asmdef       |    22 +
 Assets/Mirror/Hosting/Edgegap/Edgegap.asmdef.meta  |    14 +
 Assets/Mirror/Hosting/Edgegap/Editor.meta          |     8 +
 Assets/Mirror/Hosting/Edgegap/Editor/Api.meta      |     8 +
 .../Hosting/Edgegap/Editor/Api/EdgegapApiBase.cs   |   298 +
 .../Edgegap/Editor/Api/EdgegapApiBase.cs.meta      |    18 +
 .../Hosting/Edgegap/Editor/Api/EdgegapAppApi.cs    |   188 +
 .../Edgegap/Editor/Api/EdgegapAppApi.cs.meta       |    18 +
 .../Edgegap/Editor/Api/EdgegapDeploymentsApi.cs    |   206 +
 .../Editor/Api/EdgegapDeploymentsApi.cs.meta       |    18 +
 .../Hosting/Edgegap/Editor/Api/EdgegapIpApi.cs     |    42 +
 .../Edgegap/Editor/Api/EdgegapIpApi.cs.meta        |    18 +
 .../Hosting/Edgegap/Editor/Api/EdgegapWizardApi.cs |    52 +
 .../Edgegap/Editor/Api/EdgegapWizardApi.cs.meta    |    18 +
 .../Mirror/Hosting/Edgegap/Editor/Api/Models.meta  |     8 +
 .../Edgegap/Editor/Api/Models/AppPortsData.cs      |    28 +
 .../Edgegap/Editor/Api/Models/AppPortsData.cs.meta |    18 +
 .../Editor/Api/Models/DeploymentPortsData.cs       |    29 +
 .../Editor/Api/Models/DeploymentPortsData.cs.meta  |    10 +
 .../Edgegap/Editor/Api/Models/LocationData.cs      |    28 +
 .../Edgegap/Editor/Api/Models/LocationData.cs.meta |    18 +
 .../Edgegap/Editor/Api/Models/ProtocolType.cs      |    18 +
 .../Edgegap/Editor/Api/Models/ProtocolType.cs.meta |    18 +
 .../Edgegap/Editor/Api/Models/Requests.meta        |     8 +
 .../Editor/Api/Models/Requests/CreateAppRequest.cs |    55 +
 .../Api/Models/Requests/CreateAppRequest.cs.meta   |    18 +
 .../Api/Models/Requests/CreateAppVersionRequest.cs |   225 +
 .../Requests/CreateAppVersionRequest.cs.meta       |    18 +
 .../Api/Models/Requests/CreateDeploymentRequest.cs |    62 +
 .../Requests/CreateDeploymentRequest.cs.meta       |    18 +
 .../Api/Models/Requests/UpdateAppVersionRequest.cs |   175 +
 .../Requests/UpdateAppVersionRequest.cs.meta       |    18 +
 .../Hosting/Edgegap/Editor/Api/Models/Results.meta |     8 +
 .../Api/Models/Results/CreateDeploymentResult.cs   |    53 +
 .../Models/Results/CreateDeploymentResult.cs.meta  |    18 +
 .../Api/Models/Results/EdgegapErrorResult.cs       |    12 +
 .../Api/Models/Results/EdgegapErrorResult.cs.meta  |    18 +
 .../Editor/Api/Models/Results/EdgegapHttpResult.cs |   120 +
 .../Api/Models/Results/EdgegapHttpResult.cs.meta   |    18 +
 .../Api/Models/Results/GetAppVersionsResult.cs     |    15 +
 .../Models/Results/GetAppVersionsResult.cs.meta    |    18 +
 .../Editor/Api/Models/Results/GetAppsResult.cs     |    15 +
 .../Api/Models/Results/GetAppsResult.cs.meta       |    18 +
 .../Api/Models/Results/GetCreateAppResult.cs       |    31 +
 .../Api/Models/Results/GetCreateAppResult.cs.meta  |    18 +
 .../Api/Models/Results/GetDeploymentResult.cs      |    20 +
 .../Api/Models/Results/GetDeploymentResult.cs.meta |    18 +
 .../Models/Results/GetDeploymentStatusResult.cs    |    89 +
 .../Results/GetDeploymentStatusResult.cs.meta      |    18 +
 .../Api/Models/Results/GetDeploymentsResult.cs     |    14 +
 .../Models/Results/GetDeploymentsResult.cs.meta    |    18 +
 .../Models/Results/GetRegistryCredentialsResult.cs |    22 +
 .../Results/GetRegistryCredentialsResult.cs.meta   |    18 +
 .../Api/Models/Results/GetYourPublicIpResult.cs    |    14 +
 .../Models/Results/GetYourPublicIpResult.cs.meta   |    18 +
 .../Models/Results/StopActiveDeploymentResult.cs   |    84 +
 .../Results/StopActiveDeploymentResult.cs.meta     |    18 +
 .../Api/Models/Results/UpsertAppVersionResult.cs   |   165 +
 .../Models/Results/UpsertAppVersionResult.cs.meta  |    18 +
 .../Edgegap/Editor/Api/Models/SessionData.cs       |    28 +
 .../Edgegap/Editor/Api/Models/SessionData.cs.meta  |    18 +
 .../Edgegap/Editor/Api/Models/VersionData.cs       |    13 +
 .../Edgegap/Editor/Api/Models/VersionData.cs.meta  |    18 +
 .../Mirror/Hosting/Edgegap/Editor/ButtonShaker.cs  |    37 +
 .../Hosting/Edgegap/Editor/ButtonShaker.cs.meta    |    18 +
 .../Hosting/Edgegap/Editor/CustomPopupContent.cs   |    70 +
 .../Edgegap/Editor/CustomPopupContent.cs.meta      |    18 +
 Assets/Mirror/Hosting/Edgegap/Editor/Dockerfile    |    17 +
 .../Mirror/Hosting/Edgegap/Editor/Dockerfile.meta  |    14 +
 .../Hosting/Edgegap/Editor/EdgegapBuildUtils.cs    |   452 +
 .../Edgegap/Editor/EdgegapBuildUtils.cs.meta       |    18 +
 .../Hosting/Edgegap/Editor/EdgegapServerData.uss   |    81 +
 .../Edgegap/Editor/EdgegapServerData.uss.meta      |    18 +
 .../Edgegap/Editor/EdgegapServerDataManager.cs     |   248 +
 .../Editor/EdgegapServerDataManager.cs.meta        |    18 +
 .../Hosting/Edgegap/Editor/EdgegapWindow.uss       |   298 +
 .../Hosting/Edgegap/Editor/EdgegapWindow.uss.meta  |    18 +
 .../Hosting/Edgegap/Editor/EdgegapWindow.uxml      |   163 +
 .../Hosting/Edgegap/Editor/EdgegapWindow.uxml.meta |    17 +
 .../Edgegap/Editor/EdgegapWindowMetadata.cs        |   243 +
 .../Edgegap/Editor/EdgegapWindowMetadata.cs.meta   |    18 +
 .../Hosting/Edgegap/Editor/EdgegapWindowV2.cs      |  2472 ++
 .../Hosting/Edgegap/Editor/EdgegapWindowV2.cs.meta |    18 +
 Assets/Mirror/Hosting/Edgegap/Editor/Fonts.meta    |     8 +
 .../Edgegap/Editor/Fonts/BaronNeue SDF.asset       |  2660 ++
 .../Edgegap/Editor/Fonts/BaronNeue SDF.asset.meta  |    15 +
 .../Edgegap/Editor/Fonts/Spartan-Regular SDF.asset |  2727 +++
 .../Editor/Fonts/Spartan-Regular SDF.asset.meta    |    15 +
 .../Editor/Fonts/Spartan-SemiBold SDF.asset        |  2739 +++
 .../Editor/Fonts/Spartan-SemiBold SDF.asset.meta   |    15 +
 .../Mirror/Hosting/Edgegap/Editor/Fonts/Src.meta   |     8 +
 .../Hosting/Edgegap/Editor/Fonts/Src/BaronNeue.otf |   Bin 0 -> 27176 bytes
 .../Edgegap/Editor/Fonts/Src/BaronNeue.otf.meta    |    28 +
 .../Hosting/Edgegap/Editor/Fonts/Src/Spartan.meta  |     8 +
 .../Editor/Fonts/Src/Spartan/Spartan-Regular.ttf   |   Bin 0 -> 38384 bytes
 .../Fonts/Src/Spartan/Spartan-Regular.ttf.meta     |    28 +
 .../Editor/Fonts/Src/Spartan/Spartan-SemiBold.ttf  |   Bin 0 -> 38392 bytes
 .../Fonts/Src/Spartan/Spartan-SemiBold.ttf.meta    |    28 +
 .../Edgegap/Editor/Fonts/Src/UbuntuMono-R.ttf      |   Bin 0 -> 205748 bytes
 .../Edgegap/Editor/Fonts/Src/UbuntuMono-R.ttf.meta |    28 +
 .../Edgegap/Editor/Fonts/UbuntuMono-R SDF.asset    |  2723 +++
 .../Editor/Fonts/UbuntuMono-R SDF.asset.meta       |    15 +
 .../Mirror/Hosting/Edgegap/Editor/GithubRelease.cs |    31 +
 .../Hosting/Edgegap/Editor/GithubRelease.cs.meta   |    18 +
 Assets/Mirror/Hosting/Edgegap/Editor/Images.meta   |     8 +
 .../Edgegap/Editor/Images/clipboard-128.png        |   Bin 0 -> 3083 bytes
 .../Edgegap/Editor/Images/clipboard-128.png.meta   |   147 +
 .../Editor/Images/discord-brands-solid-64px.png    |   Bin 0 -> 1607 bytes
 .../Images/discord-brands-solid-64px.png.meta      |   147 +
 .../Edgegap/Editor/Images/discord-brands-solid.svg |     1 +
 .../Editor/Images/discord-brands-solid.svg.meta    |    61 +
 .../Editor/Images/logo_transparent_400_alpha25.png |   Bin 0 -> 13034 bytes
 .../Images/logo_transparent_400_alpha25.png.meta   |   103 +
 .../Mirror/Hosting/Edgegap/Editor/PackageJSON.cs   |    37 +
 .../Hosting/Edgegap/Editor/PackageJSON.cs.meta     |    18 +
 Assets/Mirror/Hosting/Edgegap/Enums.meta           |     8 +
 .../Mirror/Hosting/Edgegap/Enums/ApiEnvironment.cs |    71 +
 .../Hosting/Edgegap/Enums/ApiEnvironment.cs.meta   |    18 +
 .../Mirror/Hosting/Edgegap/Enums/ServerStatus.cs   |    84 +
 .../Hosting/Edgegap/Enums/ServerStatus.cs.meta     |    18 +
 Assets/Mirror/Hosting/Edgegap/Enums/ToolState.cs   |    46 +
 .../Mirror/Hosting/Edgegap/Enums/ToolState.cs.meta |    18 +
 Assets/Mirror/Hosting/Edgegap/LICENSE.md           |    21 +
 Assets/Mirror/Hosting/Edgegap/LICENSE.md.meta      |    14 +
 Assets/Mirror/Hosting/Edgegap/Models.meta          |     8 +
 .../Edgegap/Models/AppVersionUpdatePatchData.cs    |    24 +
 .../Models/AppVersionUpdatePatchData.cs.meta       |    18 +
 .../Hosting/Edgegap/Models/DeployPostData.cs       |    24 +
 .../Hosting/Edgegap/Models/DeployPostData.cs.meta  |    18 +
 Assets/Mirror/Hosting/Edgegap/Models/SDK.meta      |     8 +
 .../Models/SDK/ApiModelContainercrashdata.cs       |    63 +
 .../Models/SDK/ApiModelContainercrashdata.cs.meta  |    18 +
 .../Edgegap/Models/SDK/ApiModelContainerlogs.cs    |    71 +
 .../Models/SDK/ApiModelContainerlogs.cs.meta       |    18 +
 .../Hosting/Edgegap/Models/SDK/AppCreation.cs      |    53 +
 .../Hosting/Edgegap/Models/SDK/AppCreation.cs.meta |    18 +
 .../Hosting/Edgegap/Models/SDK/AppVersion.cs       |   240 +
 .../Hosting/Edgegap/Models/SDK/AppVersion.cs.meta  |    18 +
 .../Models/SDK/AppVersionCreateSessionConfig.cs    |    81 +
 .../SDK/AppVersionCreateSessionConfig.cs.meta      |    18 +
 .../Hosting/Edgegap/Models/SDK/AppVersionEnv.cs    |    63 +
 .../Edgegap/Models/SDK/AppVersionEnv.cs.meta       |    18 +
 .../Hosting/Edgegap/Models/SDK/AppVersionPort.cs   |    81 +
 .../Edgegap/Models/SDK/AppVersionPort.cs.meta      |    18 +
 .../Hosting/Edgegap/Models/SDK/AppVersionProbe.cs  |    54 +
 .../Edgegap/Models/SDK/AppVersionProbe.cs.meta     |    18 +
 .../Hosting/Edgegap/Models/SDK/AppVersionUpdate.cs |   240 +
 .../Edgegap/Models/SDK/AppVersionUpdate.cs.meta    |    18 +
 .../Models/SDK/AppVersionUpdateSessionConfig.cs    |    81 +
 .../SDK/AppVersionUpdateSessionConfig.cs.meta      |    18 +
 .../Edgegap/Models/SDK/AppVersionWhitelistEntry.cs |    72 +
 .../Models/SDK/AppVersionWhitelistEntry.cs.meta    |    18 +
 .../Models/SDK/AppVersionWhitelistEntryPayload.cs  |    63 +
 .../SDK/AppVersionWhitelistEntryPayload.cs.meta    |    18 +
 .../Models/SDK/AppVersionWhitelistEntrySuccess.cs  |    53 +
 .../SDK/AppVersionWhitelistEntrySuccess.cs.meta    |    18 +
 .../Models/SDK/AppVersionWhitelistResponse.cs      |    44 +
 .../Models/SDK/AppVersionWhitelistResponse.cs.meta |    18 +
 .../Hosting/Edgegap/Models/SDK/AppVersions.cs      |    52 +
 .../Hosting/Edgegap/Models/SDK/AppVersions.cs.meta |    18 +
 .../Hosting/Edgegap/Models/SDK/Application.cs      |    81 +
 .../Hosting/Edgegap/Models/SDK/Application.cs.meta |    18 +
 .../Hosting/Edgegap/Models/SDK/ApplicationPatch.cs |    63 +
 .../Edgegap/Models/SDK/ApplicationPatch.cs.meta    |    18 +
 .../Hosting/Edgegap/Models/SDK/ApplicationPost.cs  |    63 +
 .../Edgegap/Models/SDK/ApplicationPost.cs.meta     |    18 +
 .../Hosting/Edgegap/Models/SDK/Applications.cs     |    44 +
 .../Edgegap/Models/SDK/Applications.cs.meta        |    18 +
 .../Mirror/Hosting/Edgegap/Models/SDK/BaseModel.cs |    52 +
 .../Hosting/Edgegap/Models/SDK/BaseModel.cs.meta   |    18 +
 .../Edgegap/Models/SDK/BulkSessionDelete.cs        |    54 +
 .../Edgegap/Models/SDK/BulkSessionDelete.cs.meta   |    18 +
 .../Hosting/Edgegap/Models/SDK/BulkSessionPost.cs  |    54 +
 .../Edgegap/Models/SDK/BulkSessionPost.cs.meta     |    18 +
 .../Edgegap/Models/SDK/ComponentCredentials.cs     |    54 +
 .../Models/SDK/ComponentCredentials.cs.meta        |    18 +
 .../Edgegap/Models/SDK/ContainerLogStorageModel.cs |    54 +
 .../Models/SDK/ContainerLogStorageModel.cs.meta    |    18 +
 .../Edgegap/Models/SDK/CustomBulkSessionModel.cs   |    54 +
 .../Models/SDK/CustomBulkSessionModel.cs.meta      |    18 +
 .../Edgegap/Models/SDK/CustomBulkSessionsModel.cs  |    44 +
 .../Models/SDK/CustomBulkSessionsModel.cs.meta     |    18 +
 .../Edgegap/Models/SDK/CustomSessionDeleteModel.cs |    45 +
 .../Models/SDK/CustomSessionDeleteModel.cs.meta    |    18 +
 .../Edgegap/Models/SDK/CustomSessionModel.cs       |    45 +
 .../Edgegap/Models/SDK/CustomSessionModel.cs.meta  |    18 +
 Assets/Mirror/Hosting/Edgegap/Models/SDK/Delete.cs |    54 +
 .../Hosting/Edgegap/Models/SDK/Delete.cs.meta      |    18 +
 .../Hosting/Edgegap/Models/SDK/DeployEnvModel.cs   |    63 +
 .../Edgegap/Models/SDK/DeployEnvModel.cs.meta      |    18 +
 .../Hosting/Edgegap/Models/SDK/DeployModel.cs      |   180 +
 .../Hosting/Edgegap/Models/SDK/DeployModel.cs.meta |    18 +
 .../Hosting/Edgegap/Models/SDK/Deployment.cs       |   134 +
 .../Hosting/Edgegap/Models/SDK/Deployment.cs.meta  |    18 +
 .../Edgegap/Models/SDK/DeploymentLocation.cs       |    99 +
 .../Edgegap/Models/SDK/DeploymentLocation.cs.meta  |    18 +
 .../Edgegap/Models/SDK/DeploymentSessionContext.cs |    90 +
 .../Models/SDK/DeploymentSessionContext.cs.meta    |    18 +
 .../Hosting/Edgegap/Models/SDK/Deployments.cs      |    72 +
 .../Hosting/Edgegap/Models/SDK/Deployments.cs.meta |    18 +
 Assets/Mirror/Hosting/Edgegap/Models/SDK/Error.cs  |    45 +
 .../Hosting/Edgegap/Models/SDK/Error.cs.meta       |    18 +
 .../Hosting/Edgegap/Models/SDK/GeoIpListModel.cs   |    63 +
 .../Edgegap/Models/SDK/GeoIpListModel.cs.meta      |    18 +
 .../Mirror/Hosting/Edgegap/Models/SDK/Location.cs  |   108 +
 .../Hosting/Edgegap/Models/SDK/Location.cs.meta    |    18 +
 .../Hosting/Edgegap/Models/SDK/LocationModel.cs    |    54 +
 .../Edgegap/Models/SDK/LocationModel.cs.meta       |    18 +
 .../Mirror/Hosting/Edgegap/Models/SDK/Locations.cs |    53 +
 .../Hosting/Edgegap/Models/SDK/Locations.cs.meta   |    18 +
 .../Models/SDK/MatchmakerComponentCreate.cs        |    81 +
 .../Models/SDK/MatchmakerComponentCreate.cs.meta   |    18 +
 .../SDK/MatchmakerComponentEnvListResponse.cs      |    54 +
 .../SDK/MatchmakerComponentEnvListResponse.cs.meta |    18 +
 .../Models/SDK/MatchmakerComponentEnvsCreate.cs    |    54 +
 .../SDK/MatchmakerComponentEnvsCreate.cs.meta      |    18 +
 .../Models/SDK/MatchmakerComponentEnvsResponse.cs  |    54 +
 .../SDK/MatchmakerComponentEnvsResponse.cs.meta    |    18 +
 .../Models/SDK/MatchmakerComponentEnvsUpdate.cs    |    54 +
 .../SDK/MatchmakerComponentEnvsUpdate.cs.meta      |    18 +
 .../Models/SDK/MatchmakerComponentListResponse.cs  |    54 +
 .../SDK/MatchmakerComponentListResponse.cs.meta    |    18 +
 .../Models/SDK/MatchmakerComponentResponse.cs      |    81 +
 .../Models/SDK/MatchmakerComponentResponse.cs.meta |    18 +
 .../Models/SDK/MatchmakerComponentUpdate.cs        |    81 +
 .../Models/SDK/MatchmakerComponentUpdate.cs.meta   |    18 +
 .../Hosting/Edgegap/Models/SDK/MatchmakerCreate.cs |    45 +
 .../Edgegap/Models/SDK/MatchmakerCreate.cs.meta    |    18 +
 .../Edgegap/Models/SDK/MatchmakerListResponse.cs   |    54 +
 .../Models/SDK/MatchmakerListResponse.cs.meta      |    18 +
 .../Models/SDK/MatchmakerManagedReleaseCreate.cs   |    45 +
 .../SDK/MatchmakerManagedReleaseCreate.cs.meta     |    18 +
 .../Models/SDK/MatchmakerManagedReleaseResponse.cs |    45 +
 .../SDK/MatchmakerManagedReleaseResponse.cs.meta   |    18 +
 .../Models/SDK/MatchmakerManagedReleaseUpdate.cs   |    45 +
 .../SDK/MatchmakerManagedReleaseUpdate.cs.meta     |    18 +
 .../Models/SDK/MatchmakerReleaseConfigCreate.cs    |    54 +
 .../SDK/MatchmakerReleaseConfigCreate.cs.meta      |    18 +
 .../Models/SDK/MatchmakerReleaseConfigResponse.cs  |    54 +
 .../SDK/MatchmakerReleaseConfigResponse.cs.meta    |    18 +
 .../Models/SDK/MatchmakerReleaseConfigUpdate.cs    |    54 +
 .../SDK/MatchmakerReleaseConfigUpdate.cs.meta      |    18 +
 .../Edgegap/Models/SDK/MatchmakerReleaseCreate.cs  |    63 +
 .../Models/SDK/MatchmakerReleaseCreate.cs.meta     |    18 +
 .../Models/SDK/MatchmakerReleaseCreateBase.cs      |    45 +
 .../Models/SDK/MatchmakerReleaseCreateBase.cs.meta |    18 +
 .../Models/SDK/MatchmakerReleaseResponse.cs        |    63 +
 .../Models/SDK/MatchmakerReleaseResponse.cs.meta   |    18 +
 .../Models/SDK/MatchmakerReleaseResponseBase.cs    |    63 +
 .../SDK/MatchmakerReleaseResponseBase.cs.meta      |    18 +
 .../Edgegap/Models/SDK/MatchmakerReleaseUpdate.cs  |    63 +
 .../Models/SDK/MatchmakerReleaseUpdate.cs.meta     |    18 +
 .../Models/SDK/MatchmakerReleaseUpdateBase.cs      |    45 +
 .../Models/SDK/MatchmakerReleaseUpdateBase.cs.meta |    18 +
 .../Edgegap/Models/SDK/MatchmakerResponse.cs       |    45 +
 .../Edgegap/Models/SDK/MatchmakerResponse.cs.meta  |    18 +
 .../Hosting/Edgegap/Models/SDK/MatchmakerUpdate.cs |    45 +
 .../Edgegap/Models/SDK/MatchmakerUpdate.cs.meta    |    18 +
 .../Hosting/Edgegap/Models/SDK/MetricsModel.cs     |    60 +
 .../Edgegap/Models/SDK/MetricsModel.cs.meta        |    18 +
 .../Hosting/Edgegap/Models/SDK/MetricsResponse.cs  |    68 +
 .../Edgegap/Models/SDK/MetricsResponse.cs.meta     |    18 +
 .../Mirror/Hosting/Edgegap/Models/SDK/Monitor.cs   |    99 +
 .../Hosting/Edgegap/Models/SDK/Monitor.cs.meta     |    18 +
 .../Edgegap/Models/SDK/NetworkMetricsModel.cs      |    52 +
 .../Edgegap/Models/SDK/NetworkMetricsModel.cs.meta |    18 +
 .../Hosting/Edgegap/Models/SDK/Pagination.cs       |    89 +
 .../Hosting/Edgegap/Models/SDK/Pagination.cs.meta  |    18 +
 .../Mirror/Hosting/Edgegap/Models/SDK/Paginator.cs |    45 +
 .../Hosting/Edgegap/Models/SDK/Paginator.cs.meta   |    18 +
 .../Edgegap/Models/SDK/PatchSessionModel.cs        |    45 +
 .../Edgegap/Models/SDK/PatchSessionModel.cs.meta   |    18 +
 .../Hosting/Edgegap/Models/SDK/PortMapping.cs      |    99 +
 .../Hosting/Edgegap/Models/SDK/PortMapping.cs.meta |    18 +
 .../Mirror/Hosting/Edgegap/Models/SDK/Request.cs   |   135 +
 .../Hosting/Edgegap/Models/SDK/Request.cs.meta     |    18 +
 .../Hosting/Edgegap/Models/SDK/SelectorEnvModel.cs |    54 +
 .../Edgegap/Models/SDK/SelectorEnvModel.cs.meta    |    18 +
 .../Hosting/Edgegap/Models/SDK/SelectorModel.cs    |    63 +
 .../Edgegap/Models/SDK/SelectorModel.cs.meta       |    18 +
 .../Hosting/Edgegap/Models/SDK/SessionContext.cs   |   108 +
 .../Edgegap/Models/SDK/SessionContext.cs.meta      |    18 +
 .../Hosting/Edgegap/Models/SDK/SessionDelete.cs    |    63 +
 .../Edgegap/Models/SDK/SessionDelete.cs.meta       |    18 +
 .../Hosting/Edgegap/Models/SDK/SessionGet.cs       |   161 +
 .../Hosting/Edgegap/Models/SDK/SessionGet.cs.meta  |    18 +
 .../Hosting/Edgegap/Models/SDK/SessionModel.cs     |   144 +
 .../Edgegap/Models/SDK/SessionModel.cs.meta        |    18 +
 .../Hosting/Edgegap/Models/SDK/SessionRequest.cs   |    90 +
 .../Edgegap/Models/SDK/SessionRequest.cs.meta      |    18 +
 .../Hosting/Edgegap/Models/SDK/SessionUser.cs      |    63 +
 .../Hosting/Edgegap/Models/SDK/SessionUser.cs.meta |    18 +
 .../Edgegap/Models/SDK/SessionUserContext.cs       |    45 +
 .../Edgegap/Models/SDK/SessionUserContext.cs.meta  |    18 +
 .../Mirror/Hosting/Edgegap/Models/SDK/Sessions.cs  |    63 +
 .../Hosting/Edgegap/Models/SDK/Sessions.cs.meta    |    18 +
 .../Hosting/Edgegap/Models/SDK/StaticSites.cs      |    90 +
 .../Hosting/Edgegap/Models/SDK/StaticSites.cs.meta |    18 +
 .../Hosting/Edgegap/Models/SDK/StaticSitesList.cs  |    53 +
 .../Edgegap/Models/SDK/StaticSitesList.cs.meta     |    18 +
 Assets/Mirror/Hosting/Edgegap/Models/SDK/Status.cs |   215 +
 .../Hosting/Edgegap/Models/SDK/Status.cs.meta      |    18 +
 .../Edgegap/Models/SDK/TotalMetricsModel.cs        |    68 +
 .../Edgegap/Models/SDK/TotalMetricsModel.cs.meta   |    18 +
 .../Hosting/Edgegap/Newtonsoft_Package_Patch.cs    |   103 +
 .../Edgegap/Newtonsoft_Package_Patch.cs.meta       |    18 +
 Assets/Mirror/Hosting/Edgegap/README.md            |   101 +
 Assets/Mirror/Hosting/Edgegap/README.md.meta       |    14 +
 Assets/Mirror/Hosting/Edgegap/_MIRROR_README.md    |     9 +
 .../Mirror/Hosting/Edgegap/_MIRROR_README.md.meta  |    14 +
 Assets/Mirror/Hosting/Edgegap/package.json         |    21 +
 Assets/Mirror/Hosting/Edgegap/package.json.meta    |    14 +
 Assets/Mirror/Hosting/Readme.txt                   |     5 +
 Assets/Mirror/Hosting/Readme.txt.meta              |    10 +
 Assets/Mirror/LICENSE                              |    22 +
 Assets/Mirror/LICENSE.meta                         |     9 +
 Assets/Mirror/Plugins.meta                         |     8 +
 Assets/Mirror/Plugins/Mono.Cecil.meta              |     8 +
 Assets/Mirror/Plugins/Mono.Cecil/License.txt       |    25 +
 Assets/Mirror/Plugins/Mono.Cecil/License.txt.meta  |    14 +
 .../Mirror/Plugins/Mono.Cecil/Mono.CecilX.Mdb.dll  |   Bin 0 -> 43520 bytes
 .../Plugins/Mono.Cecil/Mono.CecilX.Mdb.dll.meta    |    99 +
 .../Mirror/Plugins/Mono.Cecil/Mono.CecilX.Pdb.dll  |   Bin 0 -> 87552 bytes
 .../Plugins/Mono.Cecil/Mono.CecilX.Pdb.dll.meta    |    99 +
 .../Plugins/Mono.Cecil/Mono.CecilX.Rocks.dll       |   Bin 0 -> 27648 bytes
 .../Plugins/Mono.Cecil/Mono.CecilX.Rocks.dll.meta  |    99 +
 Assets/Mirror/Plugins/Mono.Cecil/Mono.CecilX.dll   |   Bin 0 -> 340992 bytes
 .../Mirror/Plugins/Mono.Cecil/Mono.CecilX.dll.meta |   101 +
 Assets/Mirror/Presets.meta                         |     8 +
 .../Presets/Network Transform (Reliable).meta      |     8 +
 .../ClientAuth-Balanced.preset                     |   123 +
 .../ClientAuth-Balanced.preset.meta                |    15 +
 .../ClientAuth-Casual.preset                       |   123 +
 .../ClientAuth-Casual.preset.meta                  |    15 +
 .../ClientAuth-Responsive.preset                   |   123 +
 .../ClientAuth-Responsive.preset.meta              |    15 +
 .../ServerAuth-Balanced.preset                     |   123 +
 .../ServerAuth-Balanced.preset.meta                |    15 +
 .../Presets/Network Transform (Unreliable).meta    |     8 +
 .../ClientAuth-Balanced.preset                     |   123 +
 .../ClientAuth-Balanced.preset.meta                |    15 +
 .../ClientAuth-Casual.preset                       |   123 +
 .../ClientAuth-Casual.preset.meta                  |    15 +
 .../ClientAuth-Responsive.preset                   |   123 +
 .../ClientAuth-Responsive.preset.meta              |    15 +
 .../ServerAuth-Balanced.preset                     |   123 +
 .../ServerAuth-Balanced.preset.meta                |    15 +
 Assets/Mirror/Readme.txt                           |    15 +
 Assets/Mirror/Readme.txt.meta                      |    14 +
 Assets/Mirror/Transports.meta                      |     8 +
 Assets/Mirror/Transports/Edgegap.meta              |     8 +
 Assets/Mirror/Transports/Edgegap/EdgegapLobby.meta |     8 +
 .../EdgegapLobby/EdgegapLobbyKcpTransport.cs       |   345 +
 .../EdgegapLobby/EdgegapLobbyKcpTransport.cs.meta  |    18 +
 .../Transports/Edgegap/EdgegapLobby/LobbyApi.cs    |   295 +
 .../Edgegap/EdgegapLobby/LobbyApi.cs.meta          |    18 +
 .../EdgegapLobby/LobbyServiceCreateDialogue.cs     |   138 +
 .../LobbyServiceCreateDialogue.cs.meta             |    18 +
 .../EdgegapLobby/LobbyTransportInspector.cs        |    64 +
 .../EdgegapLobby/LobbyTransportInspector.cs.meta   |    18 +
 .../Transports/Edgegap/EdgegapLobby/Models.meta    |     3 +
 .../EdgegapLobby/Models/ListLobbiesResponse.cs     |    12 +
 .../Models/ListLobbiesResponse.cs.meta             |    18 +
 .../Edgegap/EdgegapLobby/Models/Lobby.cs           |    45 +
 .../Edgegap/EdgegapLobby/Models/Lobby.cs.meta      |    18 +
 .../Edgegap/EdgegapLobby/Models/LobbyBrief.cs      |    17 +
 .../Edgegap/EdgegapLobby/Models/LobbyBrief.cs.meta |    18 +
 .../EdgegapLobby/Models/LobbyCreateRequest.cs      |    27 +
 .../EdgegapLobby/Models/LobbyCreateRequest.cs.meta |    18 +
 .../Edgegap/EdgegapLobby/Models/LobbyIdRequest.cs  |    14 +
 .../EdgegapLobby/Models/LobbyIdRequest.cs.meta     |    18 +
 .../EdgegapLobby/Models/LobbyJoinOrLeaveRequest.cs |    17 +
 .../Models/LobbyJoinOrLeaveRequest.cs.meta         |    18 +
 .../EdgegapLobby/Models/LobbyUpdateRequest.cs      |    12 +
 .../EdgegapLobby/Models/LobbyUpdateRequest.cs.meta |    18 +
 Assets/Mirror/Transports/Edgegap/EdgegapRelay.meta |     8 +
 .../Edgegap/EdgegapRelay/EdgegapKcpClient.cs       |   141 +
 .../Edgegap/EdgegapRelay/EdgegapKcpClient.cs.meta  |    18 +
 .../Edgegap/EdgegapRelay/EdgegapKcpServer.cs       |   203 +
 .../Edgegap/EdgegapRelay/EdgegapKcpServer.cs.meta  |    18 +
 .../Edgegap/EdgegapRelay/EdgegapKcpTransport.cs    |   162 +
 .../EdgegapRelay/EdgegapKcpTransport.cs.meta       |    18 +
 .../Transports/Edgegap/EdgegapRelay/Protocol.cs    |    29 +
 .../Edgegap/EdgegapRelay/Protocol.cs.meta          |    18 +
 .../Transports/Edgegap/EdgegapRelay/README.md      |    20 +
 .../Transports/Edgegap/EdgegapRelay/README.md.meta |    14 +
 .../EdgegapRelay/RelayCredentialsFromArgs.cs       |    25 +
 .../EdgegapRelay/RelayCredentialsFromArgs.cs.meta  |    18 +
 Assets/Mirror/Transports/Edgegap/edgegap.png       |   Bin 0 -> 4347 bytes
 Assets/Mirror/Transports/Edgegap/edgegap.png.meta  |   130 +
 Assets/Mirror/Transports/Encryption.meta           |     3 +
 Assets/Mirror/Transports/Encryption/Editor.meta    |     3 +
 .../Editor/EncryptionTransportEditor.asmdef        |    18 +
 .../Editor/EncryptionTransportEditor.asmdef.meta   |    14 +
 .../Editor/EncryptionTransportInspector.cs         |    90 +
 .../Editor/EncryptionTransportInspector.cs.meta    |    10 +
 .../Transports/Encryption/EncryptedConnection.cs   |   554 +
 .../Encryption/EncryptedConnection.cs.meta         |    10 +
 .../Transports/Encryption/EncryptionCredentials.cs |   119 +
 .../Encryption/EncryptionCredentials.cs.meta       |    10 +
 .../Transports/Encryption/EncryptionTransport.cs   |   289 +
 .../Encryption/EncryptionTransport.cs.meta         |    18 +
 Assets/Mirror/Transports/Encryption/Plugins.meta   |     8 +
 .../Encryption/Plugins/BouncyCastle.meta           |     8 +
 .../Encryption/Plugins/BouncyCastle/LICENSE.md     |    15 +
 .../Plugins/BouncyCastle/LICENSE.md.meta           |    14 +
 .../Mirror.BouncyCastle.Cryptography.dll           |   Bin 0 -> 6856192 bytes
 .../Mirror.BouncyCastle.Cryptography.dll.meta      |    40 +
 Assets/Mirror/Transports/Encryption/PubKeyInfo.cs  |    12 +
 .../Transports/Encryption/PubKeyInfo.cs.meta       |    10 +
 .../Encryption/ThreadedEncryptionKcpTransport.cs   |   281 +
 .../ThreadedEncryptionKcpTransport.cs.meta         |    18 +
 Assets/Mirror/Transports/KCP.meta                  |     8 +
 Assets/Mirror/Transports/KCP/KcpTransport.cs       |   365 +
 Assets/Mirror/Transports/KCP/KcpTransport.cs.meta  |    18 +
 .../Mirror/Transports/KCP/ThreadedKcpTransport.cs  |   327 +
 .../Transports/KCP/ThreadedKcpTransport.cs.meta    |    18 +
 Assets/Mirror/Transports/KCP/kcp2k.meta            |     8 +
 Assets/Mirror/Transports/KCP/kcp2k/KCP.asmdef      |    16 +
 Assets/Mirror/Transports/KCP/kcp2k/KCP.asmdef.meta |    14 +
 Assets/Mirror/Transports/KCP/kcp2k/LICENSE.txt     |    24 +
 .../Mirror/Transports/KCP/kcp2k/LICENSE.txt.meta   |    14 +
 Assets/Mirror/Transports/KCP/kcp2k/VERSION.txt     |   261 +
 .../Mirror/Transports/KCP/kcp2k/VERSION.txt.meta   |    14 +
 Assets/Mirror/Transports/KCP/kcp2k/empty.meta      |     3 +
 .../KCP/kcp2k/empty/KcpServerNonAlloc.cs           |     1 +
 .../KCP/kcp2k/empty/KcpServerNonAlloc.cs.meta      |    10 +
 Assets/Mirror/Transports/KCP/kcp2k/highlevel.meta  |     8 +
 .../Transports/KCP/kcp2k/highlevel/Common.cs       |    75 +
 .../Transports/KCP/kcp2k/highlevel/Common.cs.meta  |    10 +
 .../Transports/KCP/kcp2k/highlevel/ErrorCode.cs    |    15 +
 .../KCP/kcp2k/highlevel/ErrorCode.cs.meta          |    10 +
 .../Transports/KCP/kcp2k/highlevel/Extensions.cs   |   166 +
 .../KCP/kcp2k/highlevel/Extensions.cs.meta         |    10 +
 .../Transports/KCP/kcp2k/highlevel/KcpChannel.cs   |    10 +
 .../KCP/kcp2k/highlevel/KcpChannel.cs.meta         |    10 +
 .../Transports/KCP/kcp2k/highlevel/KcpClient.cs    |   292 +
 .../KCP/kcp2k/highlevel/KcpClient.cs.meta          |    10 +
 .../Transports/KCP/kcp2k/highlevel/KcpConfig.cs    |    97 +
 .../KCP/kcp2k/highlevel/KcpConfig.cs.meta          |    10 +
 .../Transports/KCP/kcp2k/highlevel/KcpHeader.cs    |    57 +
 .../KCP/kcp2k/highlevel/KcpHeader.cs.meta          |    10 +
 .../Transports/KCP/kcp2k/highlevel/KcpPeer.cs      |   791 +
 .../Transports/KCP/kcp2k/highlevel/KcpPeer.cs.meta |    10 +
 .../Transports/KCP/kcp2k/highlevel/KcpServer.cs    |   412 +
 .../KCP/kcp2k/highlevel/KcpServer.cs.meta          |    10 +
 .../KCP/kcp2k/highlevel/KcpServerConnection.cs     |   126 +
 .../kcp2k/highlevel/KcpServerConnection.cs.meta    |    10 +
 .../Transports/KCP/kcp2k/highlevel/KcpState.cs     |     4 +
 .../KCP/kcp2k/highlevel/KcpState.cs.meta           |    18 +
 .../Mirror/Transports/KCP/kcp2k/highlevel/Log.cs   |    14 +
 .../Transports/KCP/kcp2k/highlevel/Log.cs.meta     |    18 +
 Assets/Mirror/Transports/KCP/kcp2k/kcp.meta        |     8 +
 Assets/Mirror/Transports/KCP/kcp2k/kcp/AckItem.cs  |     8 +
 .../Transports/KCP/kcp2k/kcp/AckItem.cs.meta       |    18 +
 .../Transports/KCP/kcp2k/kcp/AssemblyInfo.cs       |     3 +
 .../Transports/KCP/kcp2k/kcp/AssemblyInfo.cs.meta  |    10 +
 Assets/Mirror/Transports/KCP/kcp2k/kcp/Kcp.cs      |  1118 +
 Assets/Mirror/Transports/KCP/kcp2k/kcp/Kcp.cs.meta |    18 +
 Assets/Mirror/Transports/KCP/kcp2k/kcp/Pool.cs     |    46 +
 .../Mirror/Transports/KCP/kcp2k/kcp/Pool.cs.meta   |    18 +
 Assets/Mirror/Transports/KCP/kcp2k/kcp/Segment.cs  |    78 +
 .../Transports/KCP/kcp2k/kcp/Segment.cs.meta       |    18 +
 Assets/Mirror/Transports/KCP/kcp2k/kcp/Utils.cs    |    76 +
 .../Mirror/Transports/KCP/kcp2k/kcp/Utils.cs.meta  |    18 +
 Assets/Mirror/Transports/Latency.meta              |     8 +
 .../Mirror/Transports/Latency/LatencySimulation.cs |   319 +
 .../Transports/Latency/LatencySimulation.cs.meta   |    18 +
 Assets/Mirror/Transports/Middleware.meta           |     8 +
 .../Transports/Middleware/MiddlewareTransport.cs   |    66 +
 .../Middleware/MiddlewareTransport.cs.meta         |    18 +
 Assets/Mirror/Transports/Mirror.Transports.asmdef  |    19 +
 .../Transports/Mirror.Transports.asmdef.meta       |    14 +
 Assets/Mirror/Transports/Multiplex.meta            |     8 +
 .../Transports/Multiplex/MultiplexTransport.cs     |   458 +
 .../Multiplex/MultiplexTransport.cs.meta           |    18 +
 Assets/Mirror/Transports/SimpleWeb.meta            |     8 +
 .../Mirror/Transports/SimpleWeb/.cert.example.Json |     8 +
 .../Transports/SimpleWeb/.cert.example.Json.meta   |     9 +
 Assets/Mirror/Transports/SimpleWeb/Editor.meta     |     8 +
 .../Editor/ClientWebsocketSettingsDrawer.cs        |    71 +
 .../Editor/ClientWebsocketSettingsDrawer.cs.meta   |    10 +
 Assets/Mirror/Transports/SimpleWeb/SimpleWeb.meta  |     8 +
 .../Transports/SimpleWeb/SimpleWeb/AssemblyInfo.cs |     7 +
 .../SimpleWeb/SimpleWeb/AssemblyInfo.cs.meta       |    18 +
 .../Transports/SimpleWeb/SimpleWeb/CHANGELOG.md    |    48 +
 .../SimpleWeb/SimpleWeb/CHANGELOG.md.meta          |    14 +
 .../Transports/SimpleWeb/SimpleWeb/Client.meta     |     8 +
 .../SimpleWeb/Client/ClientWebsocketSettings.cs    |    17 +
 .../Client/ClientWebsocketSettings.cs.meta         |    10 +
 .../SimpleWeb/SimpleWeb/Client/SimpleWebClient.cs  |   103 +
 .../SimpleWeb/Client/SimpleWebClient.cs.meta       |    18 +
 .../SimpleWeb/SimpleWeb/Client/StandAlone.meta     |     8 +
 .../SimpleWeb/Client/StandAlone/ClientHandshake.cs |    88 +
 .../Client/StandAlone/ClientHandshake.cs.meta      |    18 +
 .../SimpleWeb/Client/StandAlone/ClientSslHelper.cs |    47 +
 .../Client/StandAlone/ClientSslHelper.cs.meta      |    18 +
 .../Client/StandAlone/WebSocketClientStandAlone.cs |   140 +
 .../StandAlone/WebSocketClientStandAlone.cs.meta   |    18 +
 .../SimpleWeb/SimpleWeb/Client/Webgl.meta          |     8 +
 .../SimpleWeb/Client/Webgl/SimpleWebJSLib.cs       |    34 +
 .../SimpleWeb/Client/Webgl/SimpleWebJSLib.cs.meta  |    18 +
 .../SimpleWeb/Client/Webgl/WebSocketClientWebGl.cs |   142 +
 .../Client/Webgl/WebSocketClientWebGl.cs.meta      |    18 +
 .../SimpleWeb/SimpleWeb/Client/Webgl/plugin.meta   |     8 +
 .../SimpleWeb/Client/Webgl/plugin/SimpleWeb.jslib  |   123 +
 .../Client/Webgl/plugin/SimpleWeb.jslib.meta       |    44 +
 .../Transports/SimpleWeb/SimpleWeb/Common.meta     |     8 +
 .../SimpleWeb/SimpleWeb/Common/BufferPool.cs       |   249 +
 .../SimpleWeb/SimpleWeb/Common/BufferPool.cs.meta  |    18 +
 .../SimpleWeb/SimpleWeb/Common/Connection.cs       |   134 +
 .../SimpleWeb/SimpleWeb/Common/Connection.cs.meta  |    18 +
 .../SimpleWeb/SimpleWeb/Common/Constants.cs        |    76 +
 .../SimpleWeb/SimpleWeb/Common/Constants.cs.meta   |    18 +
 .../SimpleWeb/SimpleWeb/Common/EventType.cs        |    10 +
 .../SimpleWeb/SimpleWeb/Common/EventType.cs.meta   |    18 +
 .../Transports/SimpleWeb/SimpleWeb/Common/Log.cs   |   270 +
 .../SimpleWeb/SimpleWeb/Common/Log.cs.meta         |    18 +
 .../SimpleWeb/SimpleWeb/Common/Message.cs          |    49 +
 .../SimpleWeb/SimpleWeb/Common/Message.cs.meta     |    18 +
 .../SimpleWeb/SimpleWeb/Common/MessageProcessor.cs |   175 +
 .../SimpleWeb/Common/MessageProcessor.cs.meta      |    18 +
 .../SimpleWeb/SimpleWeb/Common/ReadHelper.cs       |   123 +
 .../SimpleWeb/SimpleWeb/Common/ReadHelper.cs.meta  |    18 +
 .../SimpleWeb/SimpleWeb/Common/ReceiveLoop.cs      |   250 +
 .../SimpleWeb/SimpleWeb/Common/ReceiveLoop.cs.meta |    18 +
 .../SimpleWeb/SimpleWeb/Common/Request.cs          |    26 +
 .../SimpleWeb/SimpleWeb/Common/Request.cs.meta     |    18 +
 .../SimpleWeb/SimpleWeb/Common/SendLoop.cs         |   222 +
 .../SimpleWeb/SimpleWeb/Common/SendLoop.cs.meta    |    18 +
 .../SimpleWeb/SimpleWeb/Common/TcpConfig.cs        |    26 +
 .../SimpleWeb/SimpleWeb/Common/TcpConfig.cs.meta   |    18 +
 .../Transports/SimpleWeb/SimpleWeb/Common/Utils.cs |    13 +
 .../SimpleWeb/SimpleWeb/Common/Utils.cs.meta       |    18 +
 .../Mirror/Transports/SimpleWeb/SimpleWeb/LICENSE  |    21 +
 .../Transports/SimpleWeb/SimpleWeb/LICENSE.meta    |    14 +
 .../Transports/SimpleWeb/SimpleWeb/README.txt      |    19 +
 .../Transports/SimpleWeb/SimpleWeb/README.txt.meta |    14 +
 .../Transports/SimpleWeb/SimpleWeb/Server.meta     |     8 +
 .../SimpleWeb/SimpleWeb/Server/ServerHandshake.cs  |   156 +
 .../SimpleWeb/Server/ServerHandshake.cs.meta       |    18 +
 .../SimpleWeb/SimpleWeb/Server/ServerSslHelper.cs  |    74 +
 .../SimpleWeb/Server/ServerSslHelper.cs.meta       |    18 +
 .../SimpleWeb/SimpleWeb/Server/SimpleWebServer.cs  |   115 +
 .../SimpleWeb/Server/SimpleWebServer.cs.meta       |    18 +
 .../SimpleWeb/SimpleWeb/Server/WebSocketServer.cs  |   230 +
 .../SimpleWeb/Server/WebSocketServer.cs.meta       |    18 +
 .../SimpleWeb/SimpleWeb/SimpleWebTransport.asmdef  |    14 +
 .../SimpleWeb/SimpleWebTransport.asmdef.meta       |    14 +
 .../SimpleWeb/SimpleWeb/SslConfigLoader.cs         |    49 +
 .../SimpleWeb/SimpleWeb/SslConfigLoader.cs.meta    |    18 +
 .../Transports/SimpleWeb/SimpleWebTransport.cs     |   389 +
 .../SimpleWeb/SimpleWebTransport.cs.meta           |    18 +
 Assets/Mirror/Transports/Telepathy.meta            |     8 +
 Assets/Mirror/Transports/Telepathy/Telepathy.meta  |     8 +
 .../Transports/Telepathy/Telepathy/Client.cs       |   361 +
 .../Transports/Telepathy/Telepathy/Client.cs.meta  |    18 +
 .../Transports/Telepathy/Telepathy/Common.cs       |    39 +
 .../Transports/Telepathy/Telepathy/Common.cs.meta  |    18 +
 .../Telepathy/Telepathy/ConnectionState.cs         |    35 +
 .../Telepathy/Telepathy/ConnectionState.cs.meta    |    18 +
 .../Transports/Telepathy/Telepathy/EventType.cs    |     9 +
 .../Telepathy/Telepathy/EventType.cs.meta          |    18 +
 .../Mirror/Transports/Telepathy/Telepathy/LICENSE  |    21 +
 .../Transports/Telepathy/Telepathy/LICENSE.meta    |    14 +
 .../Mirror/Transports/Telepathy/Telepathy/Log.cs   |    15 +
 .../Transports/Telepathy/Telepathy/Log.cs.meta     |    18 +
 .../Telepathy/Telepathy/MagnificentReceivePipe.cs  |   222 +
 .../Telepathy/MagnificentReceivePipe.cs.meta       |    18 +
 .../Telepathy/Telepathy/MagnificentSendPipe.cs     |   165 +
 .../Telepathy/MagnificentSendPipe.cs.meta          |    18 +
 .../Telepathy/Telepathy/NetworkStreamExtensions.cs |    67 +
 .../Telepathy/NetworkStreamExtensions.cs.meta      |    18 +
 .../Mirror/Transports/Telepathy/Telepathy/Pool.cs  |    34 +
 .../Transports/Telepathy/Telepathy/Pool.cs.meta    |    18 +
 .../Transports/Telepathy/Telepathy/Server.cs       |   424 +
 .../Transports/Telepathy/Telepathy/Server.cs.meta  |    18 +
 .../Telepathy/Telepathy/Telepathy.asmdef           |    12 +
 .../Telepathy/Telepathy/Telepathy.asmdef.meta      |    14 +
 .../Telepathy/Telepathy/ThreadFunctions.cs         |   244 +
 .../Telepathy/Telepathy/ThreadFunctions.cs.meta    |    18 +
 .../Mirror/Transports/Telepathy/Telepathy/Utils.cs |    23 +
 .../Transports/Telepathy/Telepathy/Utils.cs.meta   |    18 +
 .../Mirror/Transports/Telepathy/Telepathy/VERSION  |    65 +
 .../Transports/Telepathy/Telepathy/VERSION.meta    |    14 +
 .../Transports/Telepathy/TelepathyTransport.cs     |   251 +
 .../Telepathy/TelepathyTransport.cs.meta           |    18 +
 Assets/Mirror/Transports/Threaded.meta             |     8 +
 .../Transports/Threaded/ThreadedTransport.cs       |   756 +
 .../Transports/Threaded/ThreadedTransport.cs.meta  |    18 +
 Assets/Mirror/version.txt                          |     1 +
 Assets/Mirror/version.txt.meta                     |     9 +
 Assets/PolygonStarter/Materials.meta               |     9 +
 Assets/PolygonStarter/Materials/Misc.meta          |     9 +
 .../Materials/Misc/PolygonStarter_Clouds_Mat.mat   |    76 +
 .../Misc/PolygonStarter_Clouds_Mat.mat.meta        |    16 +
 .../Materials/Misc/PolygonStarter_Mat_01_Glass.mat |    77 +
 .../Misc/PolygonStarter_Mat_01_Glass.mat.meta      |    16 +
 .../Materials/Misc/PolygonStarter_SimpleSky_01.mat |    82 +
 .../Misc/PolygonStarter_SimpleSky_01.mat.meta      |    16 +
 Assets/PolygonStarter/Materials/Plane.meta         |     9 +
 .../Plane/PolygonStarter_Mat_Plane_01.mat          |    76 +
 .../Plane/PolygonStarter_Mat_Plane_01.mat.meta     |    16 +
 .../Plane/PolygonStarter_Mat_Plane_02.mat          |    76 +
 .../Plane/PolygonStarter_Mat_Plane_02.mat.meta     |    16 +
 .../Plane/PolygonStarter_Mat_Plane_03.mat          |    76 +
 .../Plane/PolygonStarter_Mat_Plane_03.mat.meta     |    16 +
 .../Plane/PolygonStarter_Mat_Plane_04.mat          |    76 +
 .../Plane/PolygonStarter_Mat_Plane_04.mat.meta     |    16 +
 .../Materials/PolygonStarter_Mat_01.mat            |    76 +
 .../Materials/PolygonStarter_Mat_01.mat.meta       |    16 +
 .../Materials/PolygonStarter_Mat_02.mat            |    76 +
 .../Materials/PolygonStarter_Mat_02.mat.meta       |    16 +
 .../Materials/PolygonStarter_Mat_03.mat            |    76 +
 .../Materials/PolygonStarter_Mat_03.mat.meta       |    16 +
 .../Materials/PolygonStarter_Mat_04.mat            |    76 +
 .../Materials/PolygonStarter_Mat_04.mat.meta       |    16 +
 Assets/PolygonStarter/Models.meta                  |     9 +
 Assets/PolygonStarter/Models/Characters.fbx        |   Bin 0 -> 706208 bytes
 Assets/PolygonStarter/Models/Characters.fbx.meta   |  1078 +
 Assets/PolygonStarter/Models/Collision.meta        |     9 +
 .../Models/Collision/SM_Buildings_Block_1x1_01.fbx |   Bin 0 -> 22336 bytes
 .../Collision/SM_Buildings_Block_1x1_01.fbx.meta   |    90 +
 .../Collision/SM_Buildings_Column_2x3_01.fbx       |   Bin 0 -> 22336 bytes
 .../Collision/SM_Buildings_Column_2x3_01.fbx.meta  |    90 +
 .../Models/Collision/SM_Buildings_DoorFrame_01.fbx |   Bin 0 -> 23296 bytes
 .../Collision/SM_Buildings_DoorFrame_01.fbx.meta   |    90 +
 .../Models/Collision/SM_Buildings_Floor_1x1_01.fbx |   Bin 0 -> 22336 bytes
 .../Collision/SM_Buildings_Floor_1x1_01.fbx.meta   |    90 +
 .../Collision/SM_Buildings_Ramp_25_1x1_01.fbx      |   Bin 0 -> 21760 bytes
 .../Collision/SM_Buildings_Ramp_25_1x1_01.fbx.meta |    90 +
 .../Collision/SM_Buildings_Stairs_1x1_01.fbx       |   Bin 0 -> 23680 bytes
 .../Collision/SM_Buildings_Stairs_1x1_01.fbx.meta  |    90 +
 .../Collision/SM_Buildings_Stairs_1x3_01.fbx       |   Bin 0 -> 24304 bytes
 .../Collision/SM_Buildings_Stairs_1x3_01.fbx.meta  |    90 +
 .../Collision/SM_Buildings_WallDoor_2x3_01.fbx     |   Bin 0 -> 23824 bytes
 .../SM_Buildings_WallDoor_2x3_01.fbx.meta          |    90 +
 .../Collision/SM_Buildings_WallWindow_2x3_01.fbx   |   Bin 0 -> 25312 bytes
 .../SM_Buildings_WallWindow_2x3_01.fbx.meta        |    90 +
 ...SM_PolygonApocalypse_Bld_House_01_Collision.fbx |   Bin 0 -> 24992 bytes
 ...lygonApocalypse_Bld_House_01_Collision.fbx.meta |    95 +
 .../SM_PolygonCity_Veh_Car_Small_01_Collision.fbx  |   Bin 0 -> 39088 bytes
 ...PolygonCity_Veh_Car_Small_01_Collision.fbx.meta |   110 +
 .../Models/Collision/SM_Primitive_Cone_02.fbx      |   Bin 0 -> 21600 bytes
 .../Models/Collision/SM_Primitive_Cone_02.fbx.meta |    90 +
 .../Models/Collision/SM_Primitive_Cylander_02.fbx  |   Bin 0 -> 22448 bytes
 .../Collision/SM_Primitive_Cylander_02.fbx.meta    |    90 +
 .../Models/Collision/SM_Primitive_Sphere_02.fbx    |   Bin 0 -> 25232 bytes
 .../Collision/SM_Primitive_Sphere_02.fbx.meta      |    90 +
 Assets/PolygonStarter/Models/SM_Bean_Cop_01.fbx    |   Bin 0 -> 46800 bytes
 .../PolygonStarter/Models/SM_Bean_Cop_01.fbx.meta  |    95 +
 Assets/PolygonStarter/Models/SM_Bean_Cowboy_01.fbx |   Bin 0 -> 48128 bytes
 .../Models/SM_Bean_Cowboy_01.fbx.meta              |    95 +
 Assets/PolygonStarter/Models/SM_Bean_Female_01.fbx |   Bin 0 -> 38336 bytes
 .../Models/SM_Bean_Female_01.fbx.meta              |    95 +
 .../Models/SM_Bean_Town_Female_01.fbx              |   Bin 0 -> 50960 bytes
 .../Models/SM_Bean_Town_Female_01.fbx.meta         |    95 +
 Assets/PolygonStarter/Models/SM_Bld_Door_01.fbx    |   Bin 0 -> 32096 bytes
 .../PolygonStarter/Models/SM_Bld_Door_01.fbx.meta  |    95 +
 .../Models/SM_Generic_CloudRing_01.fbx             |   Bin 0 -> 609360 bytes
 .../Models/SM_Generic_CloudRing_01.fbx.meta        |   132 +
 .../PolygonStarter/Models/SM_Generic_Ground_01.fbx |   Bin 0 -> 28608 bytes
 .../Models/SM_Generic_Ground_01.fbx.meta           |    95 +
 .../PolygonStarter/Models/SM_Generic_Ground_02.fbx |   Bin 0 -> 38800 bytes
 .../Models/SM_Generic_Ground_02.fbx.meta           |    95 +
 .../PolygonStarter/Models/SM_Generic_Ground_03.fbx |   Bin 0 -> 52480 bytes
 .../Models/SM_Generic_Ground_03.fbx.meta           |    95 +
 .../PolygonStarter/Models/SM_Generic_Ground_04.fbx |   Bin 0 -> 52592 bytes
 .../Models/SM_Generic_Ground_04.fbx.meta           |    95 +
 .../Models/SM_Generic_Ground_Flat_01.fbx           |   Bin 0 -> 43952 bytes
 .../Models/SM_Generic_Ground_Flat_01.fbx.meta      |    95 +
 .../Models/SM_Generic_Mountains_Grass_02.fbx       |   Bin 0 -> 39680 bytes
 .../Models/SM_Generic_Mountains_Grass_02.fbx.meta  |    95 +
 .../Models/SM_Generic_Mountains_Soft_01.fbx        |   Bin 0 -> 33264 bytes
 .../Models/SM_Generic_Mountains_Soft_01.fbx.meta   |    95 +
 .../Models/SM_Generic_Small_Rocks_01.fbx           |   Bin 0 -> 28688 bytes
 .../Models/SM_Generic_Small_Rocks_01.fbx.meta      |    95 +
 .../Models/SM_Generic_Small_Rocks_02.fbx           |   Bin 0 -> 29520 bytes
 .../Models/SM_Generic_Small_Rocks_02.fbx.meta      |    95 +
 .../Models/SM_Generic_Small_Rocks_03.fbx           |   Bin 0 -> 23424 bytes
 .../Models/SM_Generic_Small_Rocks_03.fbx.meta      |    95 +
 .../Models/SM_Generic_Small_Rocks_04.fbx           |   Bin 0 -> 25104 bytes
 .../Models/SM_Generic_Small_Rocks_04.fbx.meta      |    95 +
 .../Models/SM_Generic_Small_Rocks_05.fbx           |   Bin 0 -> 22096 bytes
 .../Models/SM_Generic_Small_Rocks_05.fbx.meta      |    95 +
 .../Models/SM_Generic_TreeDead_01.fbx              |   Bin 0 -> 33488 bytes
 .../Models/SM_Generic_TreeDead_01.fbx.meta         |    95 +
 .../Models/SM_Generic_TreeStump_01.fbx             |   Bin 0 -> 29136 bytes
 .../Models/SM_Generic_TreeStump_01.fbx.meta        |    95 +
 .../PolygonStarter/Models/SM_Generic_Tree_01.fbx   |   Bin 0 -> 44704 bytes
 .../Models/SM_Generic_Tree_01.fbx.meta             |    95 +
 .../PolygonStarter/Models/SM_Generic_Tree_02.fbx   |   Bin 0 -> 30224 bytes
 .../Models/SM_Generic_Tree_02.fbx.meta             |    95 +
 .../PolygonStarter/Models/SM_Generic_Tree_03.fbx   |   Bin 0 -> 30992 bytes
 .../Models/SM_Generic_Tree_03.fbx.meta             |    95 +
 .../PolygonStarter/Models/SM_Generic_Tree_04.fbx   |   Bin 0 -> 33104 bytes
 .../Models/SM_Generic_Tree_04.fbx.meta             |    95 +
 .../Models/SM_PolygonApocalypse_Bld_House_01.fbx   |   Bin 0 -> 151808 bytes
 .../SM_PolygonApocalypse_Bld_House_01.fbx.meta     |    95 +
 .../Models/SM_PolygonCity_Veh_Car_Small_01.fbx     |   Bin 0 -> 185968 bytes
 .../SM_PolygonCity_Veh_Car_Small_01.fbx.meta       |   130 +
 ...SM_PolygonPrototype_Buildings_Block_1x1_01P.fbx |   Bin 0 -> 24848 bytes
 ...lygonPrototype_Buildings_Block_1x1_01P.fbx.meta |    95 +
 ...M_PolygonPrototype_Buildings_Column_2x3_01P.fbx |   Bin 0 -> 24416 bytes
 ...ygonPrototype_Buildings_Column_2x3_01P.fbx.meta |    95 +
 ...SM_PolygonPrototype_Buildings_DoorFrame_01P.fbx |   Bin 0 -> 24672 bytes
 ...lygonPrototype_Buildings_DoorFrame_01P.fbx.meta |    95 +
 ...SM_PolygonPrototype_Buildings_Floor_1x1_01P.fbx |   Bin 0 -> 23856 bytes
 ...lygonPrototype_Buildings_Floor_1x1_01P.fbx.meta |    95 +
 ...SM_PolygonPrototype_Buildings_Floor_5x5_01P.fbx |   Bin 0 -> 29888 bytes
 ...lygonPrototype_Buildings_Floor_5x5_01P.fbx.meta |    95 +
 ..._PolygonPrototype_Buildings_Ramp_25_1x1_01P.fbx |   Bin 0 -> 23616 bytes
 ...gonPrototype_Buildings_Ramp_25_1x1_01P.fbx.meta |    95 +
 ..._PolygonPrototype_Buildings_Ramp_45_1x1_01P.fbx |   Bin 0 -> 23424 bytes
 ...gonPrototype_Buildings_Ramp_45_1x1_01P.fbx.meta |    95 +
 ...M_PolygonPrototype_Buildings_Stairs_1x1_01P.fbx |   Bin 0 -> 24096 bytes
 ...ygonPrototype_Buildings_Stairs_1x1_01P.fbx.meta |    95 +
 ...M_PolygonPrototype_Buildings_Stairs_1x3_01P.fbx |   Bin 0 -> 26064 bytes
 ...ygonPrototype_Buildings_Stairs_1x3_01P.fbx.meta |    95 +
 ...PolygonPrototype_Buildings_WallDoor_2x3_01P.fbx |   Bin 0 -> 27056 bytes
 ...onPrototype_Buildings_WallDoor_2x3_01P.fbx.meta |    95 +
 ...lygonPrototype_Buildings_WallWindow_2x3_01P.fbx |   Bin 0 -> 27792 bytes
 ...Prototype_Buildings_WallWindow_2x3_01P.fbx.meta |    95 +
 .../SM_PolygonPrototype_Icon_Arrow_Small_01.fbx    |   Bin 0 -> 21728 bytes
 ...M_PolygonPrototype_Icon_Arrow_Small_01.fbx.meta |    95 +
 .../Models/SM_PolygonPrototype_Icon_Coin_01.fbx    |   Bin 0 -> 23664 bytes
 .../SM_PolygonPrototype_Icon_Coin_01.fbx.meta      |    95 +
 ...SM_PolygonPrototype_Icon_Letter_Question_01.fbx |   Bin 0 -> 26128 bytes
 ...lygonPrototype_Icon_Letter_Question_01.fbx.meta |    95 +
 .../SM_PolygonPrototype_Primitive_Cone_01P.fbx     |   Bin 0 -> 23872 bytes
 ...SM_PolygonPrototype_Primitive_Cone_01P.fbx.meta |    95 +
 .../SM_PolygonPrototype_Primitive_Cylander_01P.fbx |   Bin 0 -> 28704 bytes
 ...olygonPrototype_Primitive_Cylander_01P.fbx.meta |    95 +
 .../SM_PolygonPrototype_Primitive_Sphere_01P.fbx   |   Bin 0 -> 24896 bytes
 ..._PolygonPrototype_Primitive_Sphere_01P.fbx.meta |    95 +
 .../SM_PolygonPrototype_Primitive_Tube_01P.fbx     |   Bin 0 -> 24496 bytes
 ...SM_PolygonPrototype_Primitive_Tube_01P.fbx.meta |    95 +
 .../Models/SM_PolygonPrototype_Prop_Cone_01.fbx    |   Bin 0 -> 25232 bytes
 .../SM_PolygonPrototype_Prop_Cone_01.fbx.meta      |    95 +
 .../Models/SM_PolygonPrototype_Prop_Crate_03.fbx   |   Bin 0 -> 29776 bytes
 .../SM_PolygonPrototype_Prop_Crate_03.fbx.meta     |    95 +
 .../SM_PolygonPrototype_Prop_Ladder_1x2_01P.fbx    |   Bin 0 -> 25120 bytes
 ...M_PolygonPrototype_Prop_Ladder_1x2_01P.fbx.meta |    95 +
 .../Models/SM_PolygonPrototype_Prop_Sword_01.fbx   |   Bin 0 -> 31392 bytes
 .../SM_PolygonPrototype_Prop_Sword_01.fbx.meta     |    95 +
 .../Models/SM_PolygonPrototype_Prop_Target_03.fbx  |   Bin 0 -> 25744 bytes
 .../SM_PolygonPrototype_Prop_Target_03.fbx.meta    |    95 +
 .../Models/SM_Prop_Plane_Ring_01.fbx               |   Bin 0 -> 25056 bytes
 .../Models/SM_Prop_Plane_Ring_01.fbx.meta          |    95 +
 .../PolygonStarter/Models/SM_SimpleSky_Dome_01.fbx |   Bin 0 -> 31248 bytes
 .../Models/SM_SimpleSky_Dome_01.fbx.meta           |    95 +
 .../Models/SM_Veh_Plane_Stunt_01.fbx               |   Bin 0 -> 178992 bytes
 .../Models/SM_Veh_Plane_Stunt_01.fbx.meta          |   155 +
 Assets/PolygonStarter/Models/SM_Wep_Shield_04.fbx  |   Bin 0 -> 57536 bytes
 .../Models/SM_Wep_Shield_04.fbx.meta               |    95 +
 .../Models/SM_Wep_WaterPistol_01.fbx               |   Bin 0 -> 35200 bytes
 .../Models/SM_Wep_WaterPistol_01.fbx.meta          |   100 +
 .../PolygonStarter/Models/SM_Wep_Watergun_01.fbx   |   Bin 0 -> 53360 bytes
 .../Models/SM_Wep_Watergun_01.fbx.meta             |   110 +
 .../PolygonStarter/Models/SM_Wep_Watergun_02.fbx   |   Bin 0 -> 53888 bytes
 .../Models/SM_Wep_Watergun_02.fbx.meta             |   110 +
 Assets/PolygonStarter/Prefabs.meta                 |     9 +
 Assets/PolygonStarter/Prefabs/Characters.meta      |     9 +
 .../Prefabs/Characters/SM_Bean_Cop_01.prefab       |    82 +
 .../Prefabs/Characters/SM_Bean_Cop_01.prefab.meta  |    16 +
 .../Prefabs/Characters/SM_Bean_Cowboy_01.prefab    |    82 +
 .../Characters/SM_Bean_Cowboy_01.prefab.meta       |    16 +
 .../Prefabs/Characters/SM_Bean_Female_01.prefab    |    82 +
 .../Characters/SM_Bean_Female_01.prefab.meta       |    16 +
 .../Characters/SM_Bean_Town_Female_01.prefab       |    82 +
 .../Characters/SM_Bean_Town_Female_01.prefab.meta  |    16 +
 .../Characters/SM_Character_Female_01.prefab       |  1866 ++
 .../Characters/SM_Character_Female_01.prefab.meta  |    16 +
 .../Prefabs/Characters/SM_Character_Male_01.prefab |  1866 ++
 .../Characters/SM_Character_Male_01.prefab.meta    |    16 +
 .../PolygonStarter/Prefabs/SM_Bld_Door_01.prefab   |    95 +
 .../Prefabs/SM_Bld_Door_01.prefab.meta             |    16 +
 .../Prefabs/SM_Generic_CloudRing_01.prefab         |    85 +
 .../Prefabs/SM_Generic_CloudRing_01.prefab.meta    |    16 +
 .../Prefabs/SM_Generic_Ground_01.prefab            |    97 +
 .../Prefabs/SM_Generic_Ground_01.prefab.meta       |    16 +
 .../Prefabs/SM_Generic_Ground_02.prefab            |    97 +
 .../Prefabs/SM_Generic_Ground_02.prefab.meta       |    16 +
 .../Prefabs/SM_Generic_Ground_03.prefab            |    97 +
 .../Prefabs/SM_Generic_Ground_03.prefab.meta       |    16 +
 .../Prefabs/SM_Generic_Ground_04.prefab            |    97 +
 .../Prefabs/SM_Generic_Ground_04.prefab.meta       |    16 +
 .../Prefabs/SM_Generic_Ground_Flat_01.prefab       |    97 +
 .../Prefabs/SM_Generic_Ground_Flat_01.prefab.meta  |    16 +
 .../Prefabs/SM_Generic_Mountains_Grass_02.prefab   |    97 +
 .../SM_Generic_Mountains_Grass_02.prefab.meta      |    16 +
 .../Prefabs/SM_Generic_Mountains_Soft_01.prefab    |    97 +
 .../SM_Generic_Mountains_Soft_01.prefab.meta       |    16 +
 .../Prefabs/SM_Generic_Small_Rocks_01.prefab       |    82 +
 .../Prefabs/SM_Generic_Small_Rocks_01.prefab.meta  |    16 +
 .../Prefabs/SM_Generic_Small_Rocks_02.prefab       |    82 +
 .../Prefabs/SM_Generic_Small_Rocks_02.prefab.meta  |    16 +
 .../Prefabs/SM_Generic_Small_Rocks_03.prefab       |    82 +
 .../Prefabs/SM_Generic_Small_Rocks_03.prefab.meta  |    16 +
 .../Prefabs/SM_Generic_Small_Rocks_04.prefab       |    82 +
 .../Prefabs/SM_Generic_Small_Rocks_04.prefab.meta  |    16 +
 .../Prefabs/SM_Generic_Small_Rocks_05.prefab       |    82 +
 .../Prefabs/SM_Generic_Small_Rocks_05.prefab.meta  |    16 +
 .../Prefabs/SM_Generic_TreeDead_01.prefab          |    97 +
 .../Prefabs/SM_Generic_TreeDead_01.prefab.meta     |    16 +
 .../Prefabs/SM_Generic_TreeStump_01.prefab         |    97 +
 .../Prefabs/SM_Generic_TreeStump_01.prefab.meta    |    16 +
 .../Prefabs/SM_Generic_Tree_01.prefab              |    97 +
 .../Prefabs/SM_Generic_Tree_01.prefab.meta         |    16 +
 .../Prefabs/SM_Generic_Tree_02.prefab              |    82 +
 .../Prefabs/SM_Generic_Tree_02.prefab.meta         |    16 +
 .../Prefabs/SM_Generic_Tree_03.prefab              |    97 +
 .../Prefabs/SM_Generic_Tree_03.prefab.meta         |    16 +
 .../Prefabs/SM_Generic_Tree_04.prefab              |    97 +
 .../Prefabs/SM_Generic_Tree_04.prefab.meta         |    16 +
 .../SM_PolygonApocalypse_Bld_House_01.prefab       |    97 +
 .../SM_PolygonApocalypse_Bld_House_01.prefab.meta  |    16 +
 .../Prefabs/SM_PolygonCity_Veh_Car_Small_01.prefab |   728 +
 .../SM_PolygonCity_Veh_Car_Small_01.prefab.meta    |    16 +
 ...PolygonPrototype_Buildings_Block_1x1_01P.prefab |    95 +
 ...onPrototype_Buildings_Block_1x1_01P.prefab.meta |    16 +
 ...olygonPrototype_Buildings_Column_2x3_01P.prefab |    95 +
 ...nPrototype_Buildings_Column_2x3_01P.prefab.meta |    16 +
 ...PolygonPrototype_Buildings_DoorFrame_01P.prefab |    82 +
 ...onPrototype_Buildings_DoorFrame_01P.prefab.meta |    16 +
 ...PolygonPrototype_Buildings_Floor_1x1_01P.prefab |    95 +
 ...onPrototype_Buildings_Floor_1x1_01P.prefab.meta |    16 +
 ...PolygonPrototype_Buildings_Floor_5x5_01P.prefab |    95 +
 ...onPrototype_Buildings_Floor_5x5_01P.prefab.meta |    16 +
 ...lygonPrototype_Buildings_Ramp_25_1x1_01P.prefab |    97 +
 ...Prototype_Buildings_Ramp_25_1x1_01P.prefab.meta |    16 +
 ...lygonPrototype_Buildings_Ramp_45_1x1_01P.prefab |    97 +
 ...Prototype_Buildings_Ramp_45_1x1_01P.prefab.meta |    16 +
 ...olygonPrototype_Buildings_Stairs_1x1_01P.prefab |    97 +
 ...nPrototype_Buildings_Stairs_1x1_01P.prefab.meta |    16 +
 ...olygonPrototype_Buildings_Stairs_1x3_01P.prefab |    97 +
 ...nPrototype_Buildings_Stairs_1x3_01P.prefab.meta |    16 +
 ...ygonPrototype_Buildings_WallDoor_2x3_01P.prefab |    97 +
 ...rototype_Buildings_WallDoor_2x3_01P.prefab.meta |    16 +
 ...onPrototype_Buildings_WallWindow_2x3_01P.prefab |    97 +
 ...totype_Buildings_WallWindow_2x3_01P.prefab.meta |    16 +
 .../SM_PolygonPrototype_Icon_Arrow_Small_01.prefab |    97 +
 ...olygonPrototype_Icon_Arrow_Small_01.prefab.meta |    16 +
 .../SM_PolygonPrototype_Icon_Coin_01.prefab        |    97 +
 .../SM_PolygonPrototype_Icon_Coin_01.prefab.meta   |    16 +
 ...PolygonPrototype_Icon_Letter_Question_01.prefab |    97 +
 ...onPrototype_Icon_Letter_Question_01.prefab.meta |    16 +
 .../SM_PolygonPrototype_Primitive_Cone_01P.prefab  |    97 +
 ...PolygonPrototype_Primitive_Cone_01P.prefab.meta |    16 +
 ..._PolygonPrototype_Primitive_Cylander_01P.prefab |    97 +
 ...gonPrototype_Primitive_Cylander_01P.prefab.meta |    16 +
 ...SM_PolygonPrototype_Primitive_Sphere_01P.prefab |    97 +
 ...lygonPrototype_Primitive_Sphere_01P.prefab.meta |    16 +
 .../SM_PolygonPrototype_Primitive_Tube_01P.prefab  |    97 +
 ...PolygonPrototype_Primitive_Tube_01P.prefab.meta |    16 +
 .../SM_PolygonPrototype_Prop_Cone_01.prefab        |    97 +
 .../SM_PolygonPrototype_Prop_Cone_01.prefab.meta   |    16 +
 .../SM_PolygonPrototype_Prop_Crate_03.prefab       |    97 +
 .../SM_PolygonPrototype_Prop_Crate_03.prefab.meta  |    16 +
 .../SM_PolygonPrototype_Prop_Ladder_1x2_01P.prefab |    95 +
 ...olygonPrototype_Prop_Ladder_1x2_01P.prefab.meta |    16 +
 .../SM_PolygonPrototype_Prop_Sword_01.prefab       |    97 +
 .../SM_PolygonPrototype_Prop_Sword_01.prefab.meta  |    16 +
 .../SM_PolygonPrototype_Prop_Target_03.prefab      |    97 +
 .../SM_PolygonPrototype_Prop_Target_03.prefab.meta |    16 +
 .../Prefabs/SM_Prop_Plane_Ring_01.prefab           |    97 +
 .../Prefabs/SM_Prop_Plane_Ring_01.prefab.meta      |    16 +
 .../Prefabs/SM_SimpleSky_Dome_01.prefab            |    82 +
 .../Prefabs/SM_SimpleSky_Dome_01.prefab.meta       |    16 +
 .../Prefabs/SM_Veh_Plane_Stunt_01.prefab           |  1108 +
 .../Prefabs/SM_Veh_Plane_Stunt_01.prefab.meta      |    16 +
 .../PolygonStarter/Prefabs/SM_Wep_Shield_04.prefab |    97 +
 .../Prefabs/SM_Wep_Shield_04.prefab.meta           |    16 +
 .../Prefabs/SM_Wep_WaterPistol_01.prefab           |   184 +
 .../Prefabs/SM_Wep_WaterPistol_01.prefab.meta      |    16 +
 .../Prefabs/SM_Wep_Watergun_01.prefab              |   367 +
 .../Prefabs/SM_Wep_Watergun_01.prefab.meta         |    16 +
 .../Prefabs/SM_Wep_Watergun_02.prefab              |   367 +
 .../Prefabs/SM_Wep_Watergun_02.prefab.meta         |    16 +
 Assets/PolygonStarter/Scenes.meta                  |     9 +
 Assets/PolygonStarter/Scenes/Demo.unity            | 24164 +++++++++++++++++++
 Assets/PolygonStarter/Scenes/Demo.unity.meta       |    15 +
 Assets/PolygonStarter/Scenes/DemoSettings.lighting |    64 +
 .../Scenes/DemoSettings.lighting.meta              |    15 +
 Assets/PolygonStarter/Textures.meta                |     9 +
 .../Textures/PolygonStarter_Texture_01.png         |   Bin 0 -> 173711 bytes
 .../Textures/PolygonStarter_Texture_01.png.meta    |    81 +
 .../Textures/PolygonStarter_Texture_02.png         |   Bin 0 -> 173702 bytes
 .../Textures/PolygonStarter_Texture_02.png.meta    |    81 +
 .../Textures/PolygonStarter_Texture_03.png         |   Bin 0 -> 173709 bytes
 .../Textures/PolygonStarter_Texture_03.png.meta    |    81 +
 .../Textures/PolygonStarter_Texture_04.png         |   Bin 0 -> 173709 bytes
 .../Textures/PolygonStarter_Texture_04.png.meta    |    73 +
 .../Textures/Polygon_Plane_Texture_01.png          |   Bin 0 -> 234637 bytes
 .../Textures/Polygon_Plane_Texture_01.png.meta     |    81 +
 .../Textures/Polygon_Plane_Texture_02.png          |   Bin 0 -> 224380 bytes
 .../Textures/Polygon_Plane_Texture_02.png.meta     |    81 +
 .../Textures/Polygon_Plane_Texture_03.png          |   Bin 0 -> 223156 bytes
 .../Textures/Polygon_Plane_Texture_03.png.meta     |    81 +
 .../Textures/Polygon_Plane_Texture_04.png          |   Bin 0 -> 276517 bytes
 .../Textures/Polygon_Plane_Texture_04.png.meta     |    81 +
 .../Textures/Simple_Sky_Texture_01.png             |   Bin 0 -> 20911 bytes
 .../Textures/Simple_Sky_Texture_01.png.meta        |    89 +
 Assets/ScriptTemplates.meta                        |    16 +-
 ...irror__Network Manager-NewNetworkManager.cs.txt |   522 +-
 ...ith Actions-NewNetworkManagerWithActions.cs.txt |   730 +-
 ...rk Authenticator-NewNetworkAuthenticator.cs.txt |   212 +-
 ...r__Network Behaviour-NewNetworkBehaviour.cs.txt |   172 +-
 ...h Actions-NewNetworkBehaviourWithActions.cs.txt |   272 +-
 ...rest Management-CustomInterestManagement.cs.txt |   188 +-
 ...twork Room Manager-NewNetworkRoomManager.cs.txt |   368 +-
 ...Network Room Player-NewNetworkRoomPlayer.cs.txt |   214 +-
 ...r__Network Discovery-NewNetworkDiscovery.cs.txt |   198 +-
 ...r__Network Transform-NewNetworkTransform.cs.txt |   298 +-
 Assets/ScriptTemplates/Editor.meta                 |    16 +-
 .../ScriptTemplates/Editor/MoveToAssetsFolder.cs   |    84 +-
 Assets/Settings/Build Profiles.meta                |     8 +
 .../Settings/Build Profiles/SpaceColony-Dev.asset  |    49 +
 .../Build Profiles/SpaceColony-Dev.asset.meta      |     8 +
 Assets/Settings/PC_RPAsset.asset                   |    23 +-
 .../UniversalRenderPipelineGlobalSettings.asset    |    15 +-
 Assets/Simple UI Elements.meta                     |     8 +
 .../Simple UI Elements/Raw and SpriteSheets.meta   |     9 +
 .../Raw and SpriteSheets/Black1x.png               |   Bin 0 -> 38990 bytes
 .../Raw and SpriteSheets/Black1x.png.meta          |   137 +
 .../Raw and SpriteSheets/Black2x.png               |   Bin 0 -> 75902 bytes
 .../Raw and SpriteSheets/Black2x.png.meta          |   137 +
 .../Raw and SpriteSheets/Extras.png                |   Bin 0 -> 124418 bytes
 .../Raw and SpriteSheets/Extras.png.meta           |   137 +
 .../Raw and SpriteSheets/UI assets.svg             |  2988 +++
 .../Raw and SpriteSheets/UI assets.svg.meta        |    15 +
 .../Raw and SpriteSheets/White1x.png               |   Bin 0 -> 29845 bytes
 .../Raw and SpriteSheets/White1x.png.meta          |   137 +
 .../Raw and SpriteSheets/White2x.png               |   Bin 0 -> 59907 bytes
 .../Raw and SpriteSheets/White2x.png.meta          |   137 +
 Assets/Simple UI Elements/Scenes.meta              |     9 +
 .../Scenes/ProgressBar and Sliders.unity           |  3722 +++
 .../Scenes/ProgressBar and Sliders.unity.meta      |    15 +
 .../ProgressBar and SlidersSettings.lighting       |    63 +
 .../ProgressBar and SlidersSettings.lighting.meta  |     8 +
 Assets/Simple UI Elements/UI Elements.meta         |     9 +
 Assets/Simple UI Elements/UI Elements/Black.meta   |     9 +
 .../Simple UI Elements/UI Elements/Black/1x.meta   |     9 +
 .../UI Elements/Black/1x/BUtton 1.png              |   Bin 0 -> 1336 bytes
 .../UI Elements/Black/1x/BUtton 1.png.meta         |   137 +
 .../UI Elements/Black/1x/BUtton 2.png              |   Bin 0 -> 1830 bytes
 .../UI Elements/Black/1x/BUtton 2.png.meta         |   137 +
 .../UI Elements/Black/1x/BUtton 3.png              |   Bin 0 -> 1909 bytes
 .../UI Elements/Black/1x/BUtton 3.png.meta         |   137 +
 .../UI Elements/Black/1x/BUtton A.png              |   Bin 0 -> 1806 bytes
 .../UI Elements/Black/1x/BUtton A.png.meta         |   137 +
 .../UI Elements/Black/1x/BUtton B.png              |   Bin 0 -> 1738 bytes
 .../UI Elements/Black/1x/BUtton B.png.meta         |   137 +
 .../UI Elements/Black/1x/BUtton C.png              |   Bin 0 -> 1778 bytes
 .../UI Elements/Black/1x/BUtton C.png.meta         |   137 +
 .../UI Elements/Black/1x/Leaderboard.png           |   Bin 0 -> 1404 bytes
 .../UI Elements/Black/1x/Leaderboard.png.meta      |   137 +
 .../UI Elements/Black/1x/backward.png              |   Bin 0 -> 839 bytes
 .../UI Elements/Black/1x/backward.png.meta         |   137 +
 .../UI Elements/Black/1x/camera.png                |   Bin 0 -> 1114 bytes
 .../UI Elements/Black/1x/camera.png.meta           |   137 +
 .../UI Elements/Black/1x/cross.png                 |   Bin 0 -> 839 bytes
 .../UI Elements/Black/1x/cross.png.meta            |   137 +
 .../UI Elements/Black/1x/down arrow.png            |   Bin 0 -> 828 bytes
 .../UI Elements/Black/1x/down arrow.png.meta       |   137 +
 .../UI Elements/Black/1x/exit left.png             |   Bin 0 -> 1028 bytes
 .../UI Elements/Black/1x/exit left.png.meta        |   137 +
 .../UI Elements/Black/1x/exit right.png            |   Bin 0 -> 1007 bytes
 .../UI Elements/Black/1x/exit right.png.meta       |   137 +
 .../UI Elements/Black/1x/forward.png               |   Bin 0 -> 940 bytes
 .../UI Elements/Black/1x/forward.png.meta          |   137 +
 .../UI Elements/Black/1x/gamepad1.png              |   Bin 0 -> 1011 bytes
 .../UI Elements/Black/1x/gamepad1.png.meta         |   137 +
 .../UI Elements/Black/1x/gamepad2.png              |   Bin 0 -> 964 bytes
 .../UI Elements/Black/1x/gamepad2.png.meta         |   137 +
 .../UI Elements/Black/1x/hamburger icon.png        |   Bin 0 -> 329 bytes
 .../UI Elements/Black/1x/hamburger icon.png.meta   |   137 +
 .../UI Elements/Black/1x/home.png                  |   Bin 0 -> 971 bytes
 .../UI Elements/Black/1x/home.png.meta             |   137 +
 .../UI Elements/Black/1x/info.png                  |   Bin 0 -> 656 bytes
 .../UI Elements/Black/1x/info.png.meta             |   137 +
 .../UI Elements/Black/1x/left arrow.png            |   Bin 0 -> 777 bytes
 .../UI Elements/Black/1x/left arrow.png.meta       |   137 +
 .../UI Elements/Black/1x/left.png                  |   Bin 0 -> 550 bytes
 .../UI Elements/Black/1x/left.png.meta             |   137 +
 .../UI Elements/Black/1x/lock.png                  |   Bin 0 -> 506 bytes
 .../UI Elements/Black/1x/lock.png.meta             |   137 +
 .../UI Elements/Black/1x/menu1.png                 |   Bin 0 -> 592 bytes
 .../UI Elements/Black/1x/menu1.png.meta            |   137 +
 .../UI Elements/Black/1x/menu2.png                 |   Bin 0 -> 466 bytes
 .../UI Elements/Black/1x/menu2.png.meta            |   137 +
 .../UI Elements/Black/1x/mic off.png               |   Bin 0 -> 1168 bytes
 .../UI Elements/Black/1x/mic off.png.meta          |   137 +
 .../UI Elements/Black/1x/mic on.png                |   Bin 0 -> 836 bytes
 .../UI Elements/Black/1x/mic on.png.meta           |   137 +
 .../UI Elements/Black/1x/music off.png             |   Bin 0 -> 732 bytes
 .../UI Elements/Black/1x/music off.png.meta        |   137 +
 .../UI Elements/Black/1x/music on.png              |   Bin 0 -> 1259 bytes
 .../UI Elements/Black/1x/music on.png.meta         |   137 +
 .../UI Elements/Black/1x/noet-west arrow.png       |   Bin 0 -> 594 bytes
 .../UI Elements/Black/1x/noet-west arrow.png.meta  |   137 +
 .../UI Elements/Black/1x/north-east arrow.png      |   Bin 0 -> 623 bytes
 .../UI Elements/Black/1x/north-east arrow.png.meta |   137 +
 .../UI Elements/Black/1x/pause.png                 |   Bin 0 -> 350 bytes
 .../UI Elements/Black/1x/pause.png.meta            |   137 +
 .../UI Elements/Black/1x/right arrow.png           |   Bin 0 -> 765 bytes
 .../UI Elements/Black/1x/right arrow.png.meta      |   137 +
 .../UI Elements/Black/1x/right.png                 |   Bin 0 -> 573 bytes
 .../UI Elements/Black/1x/right.png.meta            |   137 +
 .../UI Elements/Black/1x/settings.png              |   Bin 0 -> 1686 bytes
 .../UI Elements/Black/1x/settings.png.meta         |   137 +
 .../UI Elements/Black/1x/share.png                 |   Bin 0 -> 1405 bytes
 .../UI Elements/Black/1x/share.png.meta            |   137 +
 .../UI Elements/Black/1x/sign1.png                 |   Bin 0 -> 214 bytes
 .../UI Elements/Black/1x/sign1.png.meta            |   137 +
 .../UI Elements/Black/1x/sign2.png                 |   Bin 0 -> 1151 bytes
 .../UI Elements/Black/1x/sign2.png.meta            |   137 +
 .../UI Elements/Black/1x/south-east arrow.png      |   Bin 0 -> 640 bytes
 .../UI Elements/Black/1x/south-east arrow.png.meta |   137 +
 .../UI Elements/Black/1x/south-west arrow.png      |   Bin 0 -> 604 bytes
 .../UI Elements/Black/1x/south-west arrow.png.meta |   137 +
 .../UI Elements/Black/1x/star.png                  |   Bin 0 -> 1343 bytes
 .../UI Elements/Black/1x/star.png.meta             |   137 +
 .../UI Elements/Black/1x/stop.png                  |   Bin 0 -> 306 bytes
 .../UI Elements/Black/1x/stop.png.meta             |   137 +
 .../UI Elements/Black/1x/unlock.png                |   Bin 0 -> 520 bytes
 .../UI Elements/Black/1x/unlock.png.meta           |   137 +
 .../UI Elements/Black/1x/up arrow.png              |   Bin 0 -> 825 bytes
 .../UI Elements/Black/1x/up arrow.png.meta         |   137 +
 .../Simple UI Elements/UI Elements/Black/1x/up.png |   Bin 0 -> 609 bytes
 .../UI Elements/Black/1x/up.png.meta               |   137 +
 .../UI Elements/Black/1x/video.png                 |   Bin 0 -> 844 bytes
 .../UI Elements/Black/1x/video.png.meta            |   137 +
 .../UI Elements/Black/1x/yes-tic.png               |   Bin 0 -> 1556 bytes
 .../UI Elements/Black/1x/yes-tic.png.meta          |   137 +
 .../Simple UI Elements/UI Elements/Black/2x.meta   |     9 +
 .../UI Elements/Black/2x/Button 1.png              |   Bin 0 -> 2573 bytes
 .../UI Elements/Black/2x/Button 1.png.meta         |   137 +
 .../UI Elements/Black/2x/Button 2.png              |   Bin 0 -> 3544 bytes
 .../UI Elements/Black/2x/Button 2.png.meta         |   137 +
 .../UI Elements/Black/2x/Button 3.png              |   Bin 0 -> 3771 bytes
 .../UI Elements/Black/2x/Button 3.png.meta         |   137 +
 .../UI Elements/Black/2x/Button A.png              |   Bin 0 -> 3554 bytes
 .../UI Elements/Black/2x/Button A.png.meta         |   137 +
 .../UI Elements/Black/2x/Button B.png              |   Bin 0 -> 3336 bytes
 .../UI Elements/Black/2x/Button B.png.meta         |   137 +
 .../UI Elements/Black/2x/Button C.png              |   Bin 0 -> 3464 bytes
 .../UI Elements/Black/2x/Button C.png.meta         |   137 +
 .../UI Elements/Black/2x/backward.png              |   Bin 0 -> 1589 bytes
 .../UI Elements/Black/2x/backward.png.meta         |   137 +
 .../UI Elements/Black/2x/camera.png                |   Bin 0 -> 2175 bytes
 .../UI Elements/Black/2x/camera.png.meta           |   137 +
 .../UI Elements/Black/2x/cross.png                 |   Bin 0 -> 1497 bytes
 .../UI Elements/Black/2x/cross.png.meta            |   137 +
 .../UI Elements/Black/2x/down arrow.png            |   Bin 0 -> 1541 bytes
 .../UI Elements/Black/2x/down arrow.png.meta       |   137 +
 .../UI Elements/Black/2x/down.png                  |   Bin 0 -> 1075 bytes
 .../UI Elements/Black/2x/down.png.meta             |   137 +
 .../UI Elements/Black/2x/forward.png               |   Bin 0 -> 1700 bytes
 .../UI Elements/Black/2x/forward.png.meta          |   137 +
 .../UI Elements/Black/2x/gamepad1.png              |   Bin 0 -> 1851 bytes
 .../UI Elements/Black/2x/gamepad1.png.meta         |   137 +
 .../UI Elements/Black/2x/gamepad2.png              |   Bin 0 -> 1668 bytes
 .../UI Elements/Black/2x/gamepad2.png.meta         |   137 +
 .../UI Elements/Black/2x/hamburger icon.png        |   Bin 0 -> 460 bytes
 .../UI Elements/Black/2x/hamburger icon.png.meta   |   137 +
 .../UI Elements/Black/2x/home.png                  |   Bin 0 -> 1818 bytes
 .../UI Elements/Black/2x/home.png.meta             |   137 +
 .../UI Elements/Black/2x/info.png                  |   Bin 0 -> 1212 bytes
 .../UI Elements/Black/2x/info.png.meta             |   137 +
 .../UI Elements/Black/2x/leaderboard.png           |   Bin 0 -> 2518 bytes
 .../UI Elements/Black/2x/leaderboard.png.meta      |   137 +
 .../UI Elements/Black/2x/left arrow.png            |   Bin 0 -> 1541 bytes
 .../UI Elements/Black/2x/left arrow.png.meta       |   137 +
 .../UI Elements/Black/2x/left exit.png             |   Bin 0 -> 1502 bytes
 .../UI Elements/Black/2x/left exit.png.meta        |   137 +
 .../UI Elements/Black/2x/left.png                  |   Bin 0 -> 1009 bytes
 .../UI Elements/Black/2x/left.png.meta             |   137 +
 .../UI Elements/Black/2x/lock.png                  |   Bin 0 -> 790 bytes
 .../UI Elements/Black/2x/lock.png.meta             |   137 +
 .../UI Elements/Black/2x/menu1.png                 |   Bin 0 -> 740 bytes
 .../UI Elements/Black/2x/menu1.png.meta            |   137 +
 .../UI Elements/Black/2x/menu2.png                 |   Bin 0 -> 628 bytes
 .../UI Elements/Black/2x/menu2.png.meta            |   137 +
 .../UI Elements/Black/2x/mic off.png               |   Bin 0 -> 2242 bytes
 .../UI Elements/Black/2x/mic off.png.meta          |   137 +
 .../UI Elements/Black/2x/mic on.png                |   Bin 0 -> 1679 bytes
 .../UI Elements/Black/2x/mic on.png.meta           |   137 +
 .../UI Elements/Black/2x/music off.png             |   Bin 0 -> 1392 bytes
 .../UI Elements/Black/2x/music off.png.meta        |   137 +
 .../UI Elements/Black/2x/music on.png              |   Bin 0 -> 2377 bytes
 .../UI Elements/Black/2x/music on.png.meta         |   137 +
 .../UI Elements/Black/2x/north east arrow.png      |   Bin 0 -> 975 bytes
 .../UI Elements/Black/2x/north east arrow.png.meta |   137 +
 .../UI Elements/Black/2x/north-west arrow.png      |   Bin 0 -> 992 bytes
 .../UI Elements/Black/2x/north-west arrow.png.meta |   137 +
 .../UI Elements/Black/2x/pause.png                 |   Bin 0 -> 681 bytes
 .../UI Elements/Black/2x/pause.png.meta            |   137 +
 .../UI Elements/Black/2x/right arrow.png           |   Bin 0 -> 1527 bytes
 .../UI Elements/Black/2x/right arrow.png.meta      |   137 +
 .../UI Elements/Black/2x/right exit.png            |   Bin 0 -> 1392 bytes
 .../UI Elements/Black/2x/right exit.png.meta       |   137 +
 .../UI Elements/Black/2x/right.png                 |   Bin 0 -> 969 bytes
 .../UI Elements/Black/2x/right.png.meta            |   137 +
 .../UI Elements/Black/2x/settings.png              |   Bin 0 -> 3160 bytes
 .../UI Elements/Black/2x/settings.png.meta         |   137 +
 .../UI Elements/Black/2x/share.png                 |   Bin 0 -> 2979 bytes
 .../UI Elements/Black/2x/share.png.meta            |   137 +
 .../UI Elements/Black/2x/sign1.png                 |   Bin 0 -> 246 bytes
 .../UI Elements/Black/2x/sign1.png.meta            |   137 +
 .../UI Elements/Black/2x/sign2.png                 |   Bin 0 -> 2127 bytes
 .../UI Elements/Black/2x/sign2.png.meta            |   137 +
 .../UI Elements/Black/2x/south-east arrow.png      |   Bin 0 -> 1040 bytes
 .../UI Elements/Black/2x/south-east arrow.png.meta |   137 +
 .../UI Elements/Black/2x/south-west arrow.png      |   Bin 0 -> 974 bytes
 .../UI Elements/Black/2x/south-west arrow.png.meta |   137 +
 .../UI Elements/Black/2x/star.png                  |   Bin 0 -> 2634 bytes
 .../UI Elements/Black/2x/star.png.meta             |   137 +
 .../UI Elements/Black/2x/stop.png                  |   Bin 0 -> 560 bytes
 .../UI Elements/Black/2x/stop.png.meta             |   137 +
 .../UI Elements/Black/2x/unlock.png                |   Bin 0 -> 796 bytes
 .../UI Elements/Black/2x/unlock.png.meta           |   137 +
 .../UI Elements/Black/2x/up arrow.png              |   Bin 0 -> 1517 bytes
 .../UI Elements/Black/2x/up arrow.png.meta         |   137 +
 .../Simple UI Elements/UI Elements/Black/2x/up.png |   Bin 0 -> 1057 bytes
 .../UI Elements/Black/2x/up.png.meta               |   137 +
 .../UI Elements/Black/2x/video.png                 |   Bin 0 -> 1314 bytes
 .../UI Elements/Black/2x/video.png.meta            |   137 +
 .../UI Elements/Black/2x/yes-tic.png               |   Bin 0 -> 3145 bytes
 .../UI Elements/Black/2x/yes-tic.png.meta          |   137 +
 Assets/Simple UI Elements/UI Elements/Extras.meta  |     9 +
 .../UI Elements/Extras/Circle128.meta              |     9 +
 .../UI Elements/Extras/Circle128/circle128.png     |   Bin 0 -> 2439 bytes
 .../Extras/Circle128/circle128.png.meta            |   137 +
 .../UI Elements/Extras/Circle128/circlefill2px.png |   Bin 0 -> 3144 bytes
 .../Extras/Circle128/circlefill2px.png.meta        |   137 +
 .../UI Elements/Extras/Circle128/circlefill4px.png |   Bin 0 -> 3173 bytes
 .../Extras/Circle128/circlefill4px.png.meta        |   137 +
 .../UI Elements/Extras/Circle128/circlefill8px.png |   Bin 0 -> 3137 bytes
 .../Extras/Circle128/circlefill8px.png.meta        |   137 +
 .../UI Elements/Extras/Circle256.meta              |     9 +
 .../UI Elements/Extras/Circle256/circle256.png     |   Bin 0 -> 5194 bytes
 .../Extras/Circle256/circle256.png.meta            |   137 +
 .../Extras/Circle256/circlefillRy16px256px.png     |   Bin 0 -> 6860 bytes
 .../Circle256/circlefillRy16px256px.png.meta       |   137 +
 .../Extras/Circle256/circlefillRy32px256px.png     |   Bin 0 -> 7788 bytes
 .../Circle256/circlefillRy32px256px.png.meta       |   137 +
 .../Extras/Circle256/circlefillRy8px256px.png      |   Bin 0 -> 6738 bytes
 .../Extras/Circle256/circlefillRy8px256px.png.meta |   137 +
 .../UI Elements/Extras/Circle512.meta              |     9 +
 .../UI Elements/Extras/Circle512/circle512.png     |   Bin 0 -> 11013 bytes
 .../Extras/Circle512/circle512.png.meta            |   137 +
 .../Extras/Circle512/circlefillRy15px512px.png     |   Bin 0 -> 15099 bytes
 .../Circle512/circlefillRy15px512px.png.meta       |   137 +
 .../Extras/Circle512/circlefillRy30px512px.png     |   Bin 0 -> 16999 bytes
 .../Circle512/circlefillRy30px512px.png.meta       |   137 +
 .../Extras/Circle512/circlefillRy86px512px.png     |   Bin 0 -> 16065 bytes
 .../Circle512/circlefillRy86px512px.png.meta       |   137 +
 .../UI Elements/Extras/ProgressBars.meta           |     9 +
 .../Extras/ProgressBars/Starprogress.png           |   Bin 0 -> 3968 bytes
 .../Extras/ProgressBars/Starprogress.png.meta      |   137 +
 .../UI Elements/Extras/ProgressBars/loading1.png   |   Bin 0 -> 624 bytes
 .../Extras/ProgressBars/loading1.png.meta          |   137 +
 .../UI Elements/Extras/ProgressBars/loading2.png   |   Bin 0 -> 929 bytes
 .../Extras/ProgressBars/loading2.png.meta          |   137 +
 .../Extras/ProgressBars/progressBar1.png           |   Bin 0 -> 437 bytes
 .../Extras/ProgressBars/progressBar1.png.meta      |   137 +
 .../Extras/ProgressBars/progressBar2.png           |   Bin 0 -> 927 bytes
 .../Extras/ProgressBars/progressBar2.png.meta      |   137 +
 .../Extras/ProgressBars/progressBar3.png           |   Bin 0 -> 1001 bytes
 .../Extras/ProgressBars/progressBar3.png.meta      |   137 +
 .../Extras/ProgressBars/progressBar4.png           |   Bin 0 -> 1051 bytes
 .../Extras/ProgressBars/progressBar4.png.meta      |   137 +
 .../UI Elements/Extras/Rects.meta                  |     9 +
 .../UI Elements/Extras/Rects/SquareRy8.png         |   Bin 0 -> 512 bytes
 .../UI Elements/Extras/Rects/SquareRy8.png.meta    |   137 +
 .../UI Elements/Extras/Rects/rect3pxRy8.png        |   Bin 0 -> 663 bytes
 .../UI Elements/Extras/Rects/rect3pxRy8.png.meta   |   137 +
 .../UI Elements/Extras/Rects/rect4pxRy8.png        |   Bin 0 -> 700 bytes
 .../UI Elements/Extras/Rects/rect4pxRy8.png.meta   |   137 +
 .../UI Elements/Extras/Rects/rect8pxRy8.png        |   Bin 0 -> 790 bytes
 .../UI Elements/Extras/Rects/rect8pxRy8.png.meta   |   137 +
 .../UI Elements/Extras/Rects/rectRy8.png           |   Bin 0 -> 534 bytes
 .../UI Elements/Extras/Rects/rectRy8.png.meta      |   137 +
 .../UI Elements/Extras/Rects/roundRect.png         |   Bin 0 -> 1020 bytes
 .../UI Elements/Extras/Rects/roundRect.png.meta    |   137 +
 .../UI Elements/Extras/Rects/roundRect2px.png      |   Bin 0 -> 1294 bytes
 .../UI Elements/Extras/Rects/roundRect2px.png.meta |   137 +
 .../UI Elements/Extras/Rects/roundRect4px.png      |   Bin 0 -> 1353 bytes
 .../UI Elements/Extras/Rects/roundRect4px.png.meta |   137 +
 .../UI Elements/Extras/Rects/roundRect8px.png      |   Bin 0 -> 1391 bytes
 .../UI Elements/Extras/Rects/roundRect8px.png.meta |   137 +
 .../UI Elements/Extras/circle64.png                |   Bin 0 -> 1089 bytes
 .../UI Elements/Extras/circle64.png.meta           |   137 +
 Assets/Simple UI Elements/UI Elements/White.meta   |     9 +
 .../Simple UI Elements/UI Elements/White/1x.meta   |     9 +
 .../UI Elements/White/1x/BUtton 1.png              |   Bin 0 -> 971 bytes
 .../UI Elements/White/1x/BUtton 1.png.meta         |   137 +
 .../UI Elements/White/1x/BUtton 2.png              |   Bin 0 -> 1274 bytes
 .../UI Elements/White/1x/BUtton 2.png.meta         |   137 +
 .../UI Elements/White/1x/BUtton 3.png              |   Bin 0 -> 1315 bytes
 .../UI Elements/White/1x/BUtton 3.png.meta         |   137 +
 .../UI Elements/White/1x/BUtton A.png              |   Bin 0 -> 1323 bytes
 .../UI Elements/White/1x/BUtton A.png.meta         |   137 +
 .../UI Elements/White/1x/BUtton B.png              |   Bin 0 -> 1198 bytes
 .../UI Elements/White/1x/BUtton B.png.meta         |   137 +
 .../UI Elements/White/1x/BUtton C.png              |   Bin 0 -> 1254 bytes
 .../UI Elements/White/1x/BUtton C.png.meta         |   137 +
 .../UI Elements/White/1x/Leaderboard.png           |   Bin 0 -> 1114 bytes
 .../UI Elements/White/1x/Leaderboard.png.meta      |   137 +
 .../UI Elements/White/1x/backward.png              |   Bin 0 -> 713 bytes
 .../UI Elements/White/1x/backward.png.meta         |   137 +
 .../UI Elements/White/1x/camera.png                |   Bin 0 -> 899 bytes
 .../UI Elements/White/1x/camera.png.meta           |   137 +
 .../UI Elements/White/1x/cross.png                 |   Bin 0 -> 655 bytes
 .../UI Elements/White/1x/cross.png.meta            |   137 +
 .../UI Elements/White/1x/down arrow.png            |   Bin 0 -> 576 bytes
 .../UI Elements/White/1x/down arrow.png.meta       |   137 +
 .../UI Elements/White/1x/down.png                  |   Bin 0 -> 418 bytes
 .../UI Elements/White/1x/down.png.meta             |   137 +
 .../UI Elements/White/1x/exit left.png             |   Bin 0 -> 847 bytes
 .../UI Elements/White/1x/exit left.png.meta        |   137 +
 .../UI Elements/White/1x/exit right.png            |   Bin 0 -> 801 bytes
 .../UI Elements/White/1x/exit right.png.meta       |   137 +
 .../UI Elements/White/1x/forward.png               |   Bin 0 -> 746 bytes
 .../UI Elements/White/1x/forward.png.meta          |   137 +
 .../UI Elements/White/1x/gamepad1.png              |   Bin 0 -> 819 bytes
 .../UI Elements/White/1x/gamepad1.png.meta         |   137 +
 .../UI Elements/White/1x/gamepad2.png              |   Bin 0 -> 781 bytes
 .../UI Elements/White/1x/gamepad2.png.meta         |   137 +
 .../UI Elements/White/1x/hamburger icon.png        |   Bin 0 -> 290 bytes
 .../UI Elements/White/1x/hamburger icon.png.meta   |   137 +
 .../UI Elements/White/1x/home.png                  |   Bin 0 -> 674 bytes
 .../UI Elements/White/1x/home.png.meta             |   137 +
 .../UI Elements/White/1x/info.png                  |   Bin 0 -> 501 bytes
 .../UI Elements/White/1x/info.png.meta             |   137 +
 .../UI Elements/White/1x/left arrow.png            |   Bin 0 -> 542 bytes
 .../UI Elements/White/1x/left arrow.png.meta       |   137 +
 .../UI Elements/White/1x/left.png                  |   Bin 0 -> 498 bytes
 .../UI Elements/White/1x/left.png.meta             |   137 +
 .../UI Elements/White/1x/lock.png                  |   Bin 0 -> 434 bytes
 .../UI Elements/White/1x/lock.png.meta             |   137 +
 .../UI Elements/White/1x/menu1.png                 |   Bin 0 -> 479 bytes
 .../UI Elements/White/1x/menu1.png.meta            |   137 +
 .../UI Elements/White/1x/menu2.png                 |   Bin 0 -> 416 bytes
 .../UI Elements/White/1x/menu2.png.meta            |   137 +
 .../UI Elements/White/1x/mic off.png               |   Bin 0 -> 854 bytes
 .../UI Elements/White/1x/mic off.png.meta          |   137 +
 .../UI Elements/White/1x/mic on.png                |   Bin 0 -> 613 bytes
 .../UI Elements/White/1x/mic on.png.meta           |   137 +
 .../UI Elements/White/1x/music off.png             |   Bin 0 -> 463 bytes
 .../UI Elements/White/1x/music off.png.meta        |   137 +
 .../UI Elements/White/1x/music on.png              |   Bin 0 -> 753 bytes
 .../UI Elements/White/1x/music on.png.meta         |   137 +
 .../UI Elements/White/1x/noet-west arrow.png       |   Bin 0 -> 528 bytes
 .../UI Elements/White/1x/noet-west arrow.png.meta  |   137 +
 .../UI Elements/White/1x/north-east arrow.png      |   Bin 0 -> 496 bytes
 .../UI Elements/White/1x/north-east arrow.png.meta |   137 +
 .../UI Elements/White/1x/pause.png                 |   Bin 0 -> 308 bytes
 .../UI Elements/White/1x/pause.png.meta            |   137 +
 .../UI Elements/White/1x/right arrow.png           |   Bin 0 -> 496 bytes
 .../UI Elements/White/1x/right arrow.png.meta      |   137 +
 .../UI Elements/White/1x/right.png                 |   Bin 0 -> 479 bytes
 .../UI Elements/White/1x/right.png.meta            |   137 +
 .../UI Elements/White/1x/settings.png              |   Bin 0 -> 1123 bytes
 .../UI Elements/White/1x/settings.png.meta         |   137 +
 .../UI Elements/White/1x/share.png                 |   Bin 0 -> 949 bytes
 .../UI Elements/White/1x/share.png.meta            |   137 +
 .../UI Elements/White/1x/sign1.png                 |   Bin 0 -> 199 bytes
 .../UI Elements/White/1x/sign1.png.meta            |   137 +
 .../UI Elements/White/1x/sign2.png                 |   Bin 0 -> 754 bytes
 .../UI Elements/White/1x/sign2.png.meta            |   137 +
 .../UI Elements/White/1x/south-east arrow.png      |   Bin 0 -> 528 bytes
 .../UI Elements/White/1x/south-east arrow.png.meta |   137 +
 .../UI Elements/White/1x/south-west arrow.png      |   Bin 0 -> 528 bytes
 .../UI Elements/White/1x/south-west arrow.png.meta |   137 +
 .../UI Elements/White/1x/star.png                  |   Bin 0 -> 914 bytes
 .../UI Elements/White/1x/star.png.meta             |   137 +
 .../UI Elements/White/1x/stop.png                  |   Bin 0 -> 288 bytes
 .../UI Elements/White/1x/stop.png.meta             |   137 +
 .../UI Elements/White/1x/unlock.png                |   Bin 0 -> 445 bytes
 .../UI Elements/White/1x/unlock.png.meta           |   137 +
 .../UI Elements/White/1x/up arrow.png              |   Bin 0 -> 569 bytes
 .../UI Elements/White/1x/up arrow.png.meta         |   137 +
 .../Simple UI Elements/UI Elements/White/1x/up.png |   Bin 0 -> 408 bytes
 .../UI Elements/White/1x/up.png.meta               |   137 +
 .../UI Elements/White/1x/video.png                 |   Bin 0 -> 722 bytes
 .../UI Elements/White/1x/video.png.meta            |   137 +
 .../UI Elements/White/1x/yes-tic.png               |   Bin 0 -> 863 bytes
 .../UI Elements/White/1x/yes-tic.png.meta          |   137 +
 .../Simple UI Elements/UI Elements/White/2x.meta   |     9 +
 .../UI Elements/White/2x/Button 1.png              |   Bin 0 -> 2112 bytes
 .../UI Elements/White/2x/Button 1.png.meta         |   137 +
 .../UI Elements/White/2x/Button 2.png              |   Bin 0 -> 2739 bytes
 .../UI Elements/White/2x/Button 2.png.meta         |   137 +
 .../UI Elements/White/2x/Button 3.png              |   Bin 0 -> 2858 bytes
 .../UI Elements/White/2x/Button 3.png.meta         |   137 +
 .../UI Elements/White/2x/Button A.png              |   Bin 0 -> 2879 bytes
 .../UI Elements/White/2x/Button A.png.meta         |   137 +
 .../UI Elements/White/2x/Button B.png              |   Bin 0 -> 2661 bytes
 .../UI Elements/White/2x/Button B.png.meta         |   137 +
 .../UI Elements/White/2x/Button C.png              |   Bin 0 -> 2684 bytes
 .../UI Elements/White/2x/Button C.png.meta         |   137 +
 .../UI Elements/White/2x/backward.png              |   Bin 0 -> 1355 bytes
 .../UI Elements/White/2x/backward.png.meta         |   137 +
 .../UI Elements/White/2x/camera.png                |   Bin 0 -> 1752 bytes
 .../UI Elements/White/2x/camera.png.meta           |   137 +
 .../UI Elements/White/2x/cross.png                 |   Bin 0 -> 1232 bytes
 .../UI Elements/White/2x/cross.png.meta            |   137 +
 .../UI Elements/White/2x/down arrow.png            |   Bin 0 -> 1142 bytes
 .../UI Elements/White/2x/down arrow.png.meta       |   137 +
 .../UI Elements/White/2x/down.png                  |   Bin 0 -> 799 bytes
 .../UI Elements/White/2x/down.png.meta             |   137 +
 .../UI Elements/White/2x/forward.png               |   Bin 0 -> 1422 bytes
 .../UI Elements/White/2x/forward.png.meta          |   137 +
 .../UI Elements/White/2x/gamepad1.png              |   Bin 0 -> 1521 bytes
 .../UI Elements/White/2x/gamepad1.png.meta         |   137 +
 .../UI Elements/White/2x/gamepad2.png              |   Bin 0 -> 1401 bytes
 .../UI Elements/White/2x/gamepad2.png.meta         |   137 +
 .../UI Elements/White/2x/hamburger icon.png        |   Bin 0 -> 446 bytes
 .../UI Elements/White/2x/hamburger icon.png.meta   |   137 +
 .../UI Elements/White/2x/home.png                  |   Bin 0 -> 1373 bytes
 .../UI Elements/White/2x/home.png.meta             |   137 +
 .../UI Elements/White/2x/info.png                  |   Bin 0 -> 909 bytes
 .../UI Elements/White/2x/info.png.meta             |   137 +
 .../UI Elements/White/2x/leaderboard.png           |   Bin 0 -> 2096 bytes
 .../UI Elements/White/2x/leaderboard.png.meta      |   137 +
 .../UI Elements/White/2x/left arrow.png            |   Bin 0 -> 1131 bytes
 .../UI Elements/White/2x/left arrow.png.meta       |   137 +
 .../UI Elements/White/2x/left exit.png             |   Bin 0 -> 1270 bytes
 .../UI Elements/White/2x/left exit.png.meta        |   137 +
 .../UI Elements/White/2x/left.png                  |   Bin 0 -> 740 bytes
 .../UI Elements/White/2x/left.png.meta             |   137 +
 .../UI Elements/White/2x/lock.png                  |   Bin 0 -> 694 bytes
 .../UI Elements/White/2x/lock.png.meta             |   137 +
 .../UI Elements/White/2x/menu1.png                 |   Bin 0 -> 666 bytes
 .../UI Elements/White/2x/menu1.png.meta            |   137 +
 .../UI Elements/White/2x/menu2.png                 |   Bin 0 -> 598 bytes
 .../UI Elements/White/2x/menu2.png.meta            |   137 +
 .../UI Elements/White/2x/mic off.png               |   Bin 0 -> 1545 bytes
 .../UI Elements/White/2x/mic off.png.meta          |   137 +
 .../UI Elements/White/2x/mic on.png                |   Bin 0 -> 1227 bytes
 .../UI Elements/White/2x/mic on.png.meta           |   137 +
 .../UI Elements/White/2x/music off.png             |   Bin 0 -> 1040 bytes
 .../UI Elements/White/2x/music off.png.meta        |   137 +
 .../UI Elements/White/2x/music on.png              |   Bin 0 -> 1698 bytes
 .../UI Elements/White/2x/music on.png.meta         |   137 +
 .../UI Elements/White/2x/north east arrow.png      |   Bin 0 -> 880 bytes
 .../UI Elements/White/2x/north east arrow.png.meta |   137 +
 .../UI Elements/White/2x/north-west arrow.png      |   Bin 0 -> 915 bytes
 .../UI Elements/White/2x/north-west arrow.png.meta |   137 +
 .../UI Elements/White/2x/pause.png                 |   Bin 0 -> 569 bytes
 .../UI Elements/White/2x/pause.png.meta            |   137 +
 .../UI Elements/White/2x/right arrow.png           |   Bin 0 -> 1109 bytes
 .../UI Elements/White/2x/right arrow.png.meta      |   137 +
 .../UI Elements/White/2x/right exit.png            |   Bin 0 -> 1187 bytes
 .../UI Elements/White/2x/right exit.png.meta       |   137 +
 .../UI Elements/White/2x/right.png                 |   Bin 0 -> 767 bytes
 .../UI Elements/White/2x/right.png.meta            |   137 +
 .../UI Elements/White/2x/settings.png              |   Bin 0 -> 2145 bytes
 .../UI Elements/White/2x/settings.png.meta         |   137 +
 .../UI Elements/White/2x/share.png                 |   Bin 0 -> 2086 bytes
 .../UI Elements/White/2x/share.png.meta            |   137 +
 .../UI Elements/White/2x/sign1.png                 |   Bin 0 -> 225 bytes
 .../UI Elements/White/2x/sign1.png.meta            |   137 +
 .../UI Elements/White/2x/sign2.png                 |   Bin 0 -> 1471 bytes
 .../UI Elements/White/2x/sign2.png.meta            |   137 +
 .../UI Elements/White/2x/south-east arrow.png      |   Bin 0 -> 935 bytes
 .../UI Elements/White/2x/south-east arrow.png.meta |   137 +
 .../UI Elements/White/2x/south-west arrow.png      |   Bin 0 -> 879 bytes
 .../UI Elements/White/2x/south-west arrow.png.meta |   137 +
 .../UI Elements/White/2x/star.png                  |   Bin 0 -> 1970 bytes
 .../UI Elements/White/2x/star.png.meta             |   137 +
 .../UI Elements/White/2x/stop.png                  |   Bin 0 -> 517 bytes
 .../UI Elements/White/2x/stop.png.meta             |   137 +
 .../UI Elements/White/2x/unlock.png                |   Bin 0 -> 698 bytes
 .../UI Elements/White/2x/unlock.png.meta           |   137 +
 .../UI Elements/White/2x/up arrow.png              |   Bin 0 -> 1104 bytes
 .../UI Elements/White/2x/up arrow.png.meta         |   137 +
 .../Simple UI Elements/UI Elements/White/2x/up.png |   Bin 0 -> 760 bytes
 .../UI Elements/White/2x/up.png.meta               |   137 +
 .../UI Elements/White/2x/video.png                 |   Bin 0 -> 1115 bytes
 .../UI Elements/White/2x/video.png.meta            |   137 +
 .../UI Elements/White/2x/yes-tic.png               |   Bin 0 -> 2034 bytes
 .../UI Elements/White/2x/yes-tic.png.meta          |   137 +
 .../Lowpoly Demo Post-processing Profile.asset     |  1470 ++
 ...Lowpoly Demo Post-processing Profile.asset.meta |    15 +
 Assets/SimpleLowPolyNature/Materials.meta          |     8 +
 Assets/SimpleLowPolyNature/Materials/CloudMat.mat  |    77 +
 .../Materials/CloudMat.mat.meta                    |    15 +
 .../SimpleLowPolyNature/Materials/DemoPlaneMat.mat |    77 +
 .../Materials/DemoPlaneMat.mat.meta                |    15 +
 .../Materials/EmissionBlueMat.mat                  |    77 +
 .../Materials/EmissionBlueMat.mat.meta             |    15 +
 .../Materials/EmissionYellowMat.mat                |    77 +
 .../Materials/EmissionYellowMat.mat.meta           |    15 +
 .../Materials/FireParticleAddMat.mat               |   103 +
 .../Materials/FireParticleAddMat.mat.meta          |    15 +
 .../Materials/FireParticleMat.mat                  |   102 +
 .../Materials/FireParticleMat.mat.meta             |    15 +
 .../SimpleLowPolyNature/Materials/Flower1Mat.mat   |    77 +
 .../Materials/Flower1Mat.mat.meta                  |    15 +
 .../SimpleLowPolyNature/Materials/Flower2Mat.mat   |    77 +
 .../Materials/Flower2Mat.mat.meta                  |    15 +
 .../SimpleLowPolyNature/Materials/Flower3Mat.mat   |    77 +
 .../Materials/Flower3Mat.mat.meta                  |    15 +
 .../SimpleLowPolyNature/Materials/Flower4Mat.mat   |    77 +
 .../Materials/Flower4Mat.mat.meta                  |    15 +
 .../SimpleLowPolyNature/Materials/Mushroom1Mat.mat |    77 +
 .../Materials/Mushroom1Mat.mat.meta                |    15 +
 .../SimpleLowPolyNature/Materials/Mushroom2Mat.mat |    77 +
 .../Materials/Mushroom2Mat.mat.meta                |    15 +
 .../SimpleLowPolyNature/Materials/Mushroom3Mat.mat |    77 +
 .../Materials/Mushroom3Mat.mat.meta                |    15 +
 Assets/SimpleLowPolyNature/Materials/PlantMat.mat  |    77 +
 .../Materials/PlantMat.mat.meta                    |    15 +
 Assets/SimpleLowPolyNature/Materials/RockMat.mat   |    77 +
 .../SimpleLowPolyNature/Materials/RockMat.mat.meta |    15 +
 .../Materials/TreeGreen1Mat.mat                    |    77 +
 .../Materials/TreeGreen1Mat.mat.meta               |    15 +
 .../Materials/TreeGreen2Mat.mat                    |    77 +
 .../Materials/TreeGreen2Mat.mat.meta               |    15 +
 .../Materials/TreeOrangeMat.mat                    |    77 +
 .../Materials/TreeOrangeMat.mat.meta               |    15 +
 .../SimpleLowPolyNature/Materials/TreePinkMat.mat  |    77 +
 .../Materials/TreePinkMat.mat.meta                 |    15 +
 .../SimpleLowPolyNature/Materials/TreeRedMat.mat   |    77 +
 .../Materials/TreeRedMat.mat.meta                  |    15 +
 .../Materials/TreeYellowMat.mat                    |    77 +
 .../Materials/TreeYellowMat.mat.meta               |    15 +
 Assets/SimpleLowPolyNature/Materials/WaterMat.mat  |    84 +
 .../Materials/WaterMat.mat.meta                    |    15 +
 Assets/SimpleLowPolyNature/Materials/Wood1Mat.mat  |    77 +
 .../Materials/Wood1Mat.mat.meta                    |    15 +
 Assets/SimpleLowPolyNature/Materials/Wood2Mat.mat  |    77 +
 .../Materials/Wood2Mat.mat.meta                    |    15 +
 Assets/SimpleLowPolyNature/Models.meta             |     8 +
 Assets/SimpleLowPolyNature/Models/Cloud1.fbx       |   Bin 0 -> 15932 bytes
 Assets/SimpleLowPolyNature/Models/Cloud1.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Cloud2.fbx       |   Bin 0 -> 14988 bytes
 Assets/SimpleLowPolyNature/Models/Cloud2.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/FallenBranch.fbx |   Bin 0 -> 17644 bytes
 .../Models/FallenBranch.fbx.meta                   |   104 +
 Assets/SimpleLowPolyNature/Models/FireParticle.fbx |   Bin 0 -> 11932 bytes
 .../Models/FireParticle.fbx.meta                   |   104 +
 Assets/SimpleLowPolyNature/Models/FireWood.fbx     |   Bin 0 -> 21388 bytes
 .../SimpleLowPolyNature/Models/FireWood.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Flower1.fbx      |   Bin 0 -> 23644 bytes
 Assets/SimpleLowPolyNature/Models/Flower1.fbx.meta |   105 +
 Assets/SimpleLowPolyNature/Models/Flower2.fbx      |   Bin 0 -> 24204 bytes
 Assets/SimpleLowPolyNature/Models/Flower2.fbx.meta |   105 +
 Assets/SimpleLowPolyNature/Models/Flower3.fbx      |   Bin 0 -> 24172 bytes
 Assets/SimpleLowPolyNature/Models/Flower3.fbx.meta |   105 +
 Assets/SimpleLowPolyNature/Models/Grass1.fbx       |   Bin 0 -> 13420 bytes
 Assets/SimpleLowPolyNature/Models/Grass1.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Grass2.fbx       |   Bin 0 -> 15260 bytes
 Assets/SimpleLowPolyNature/Models/Grass2.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Grass3.fbx       |   Bin 0 -> 14636 bytes
 Assets/SimpleLowPolyNature/Models/Grass3.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Grass4.fbx       |   Bin 0 -> 13356 bytes
 Assets/SimpleLowPolyNature/Models/Grass4.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Ivy1.fbx         |   Bin 0 -> 16172 bytes
 Assets/SimpleLowPolyNature/Models/Ivy1.fbx.meta    |   104 +
 Assets/SimpleLowPolyNature/Models/Ivy2.fbx         |   Bin 0 -> 17660 bytes
 Assets/SimpleLowPolyNature/Models/Ivy2.fbx.meta    |   104 +
 .../SimpleLowPolyNature/Models/LightingPlant1.fbx  |   Bin 0 -> 22828 bytes
 .../Models/LightingPlant1.fbx.meta                 |   105 +
 .../SimpleLowPolyNature/Models/LightingPlant2.fbx  |   Bin 0 -> 21196 bytes
 .../Models/LightingPlant2.fbx.meta                 |   105 +
 Assets/SimpleLowPolyNature/Models/Log.fbx          |   Bin 0 -> 18268 bytes
 Assets/SimpleLowPolyNature/Models/Log.fbx.meta     |   105 +
 .../SimpleLowPolyNature/Models/LowpolyTerrain.fbx  |   Bin 0 -> 62684 bytes
 .../Models/LowpolyTerrain.fbx.meta                 |   104 +
 Assets/SimpleLowPolyNature/Models/Mushroom1.fbx    |   Bin 0 -> 17244 bytes
 .../SimpleLowPolyNature/Models/Mushroom1.fbx.meta  |   105 +
 Assets/SimpleLowPolyNature/Models/Mushroom2.fbx    |   Bin 0 -> 17340 bytes
 .../SimpleLowPolyNature/Models/Mushroom2.fbx.meta  |   105 +
 .../SimpleLowPolyNature/Models/MushroomLarge.fbx   |   Bin 0 -> 17772 bytes
 .../Models/MushroomLarge.fbx.meta                  |   105 +
 Assets/SimpleLowPolyNature/Models/Paddle.fbx       |   Bin 0 -> 11740 bytes
 Assets/SimpleLowPolyNature/Models/Paddle.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Plant1.fbx       |   Bin 0 -> 13564 bytes
 Assets/SimpleLowPolyNature/Models/Plant1.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Plant2.fbx       |   Bin 0 -> 15740 bytes
 Assets/SimpleLowPolyNature/Models/Plant2.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Plant3.fbx       |   Bin 0 -> 14076 bytes
 Assets/SimpleLowPolyNature/Models/Plant3.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Plant4.fbx       |   Bin 0 -> 24060 bytes
 Assets/SimpleLowPolyNature/Models/Plant4.fbx.meta  |   105 +
 Assets/SimpleLowPolyNature/Models/Rock1.fbx        |   Bin 0 -> 14092 bytes
 Assets/SimpleLowPolyNature/Models/Rock1.fbx.meta   |   105 +
 Assets/SimpleLowPolyNature/Models/Rock10.fbx       |   Bin 0 -> 15228 bytes
 Assets/SimpleLowPolyNature/Models/Rock10.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Rock11.fbx       |   Bin 0 -> 15164 bytes
 Assets/SimpleLowPolyNature/Models/Rock11.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Rock12.fbx       |   Bin 0 -> 14108 bytes
 Assets/SimpleLowPolyNature/Models/Rock12.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/Rock2.fbx        |   Bin 0 -> 13932 bytes
 Assets/SimpleLowPolyNature/Models/Rock2.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Rock3.fbx        |   Bin 0 -> 13836 bytes
 Assets/SimpleLowPolyNature/Models/Rock3.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Rock4.fbx        |   Bin 0 -> 15228 bytes
 Assets/SimpleLowPolyNature/Models/Rock4.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Rock5.fbx        |   Bin 0 -> 19708 bytes
 Assets/SimpleLowPolyNature/Models/Rock5.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Rock6.fbx        |   Bin 0 -> 15820 bytes
 Assets/SimpleLowPolyNature/Models/Rock6.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Rock7.fbx        |   Bin 0 -> 12540 bytes
 Assets/SimpleLowPolyNature/Models/Rock7.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Rock8.fbx        |   Bin 0 -> 12940 bytes
 Assets/SimpleLowPolyNature/Models/Rock8.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Rock9.fbx        |   Bin 0 -> 15004 bytes
 Assets/SimpleLowPolyNature/Models/Rock9.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Tent.fbx         |   Bin 0 -> 18044 bytes
 Assets/SimpleLowPolyNature/Models/Tent.fbx.meta    |   105 +
 Assets/SimpleLowPolyNature/Models/Tree1.fbx        |   Bin 0 -> 27132 bytes
 Assets/SimpleLowPolyNature/Models/Tree1.fbx.meta   |   105 +
 Assets/SimpleLowPolyNature/Models/Tree2.fbx        |   Bin 0 -> 24012 bytes
 Assets/SimpleLowPolyNature/Models/Tree2.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/Tree3.fbx        |   Bin 0 -> 35580 bytes
 Assets/SimpleLowPolyNature/Models/Tree3.fbx.meta   |   106 +
 Assets/SimpleLowPolyNature/Models/TreeDead1.fbx    |   Bin 0 -> 16044 bytes
 .../SimpleLowPolyNature/Models/TreeDead1.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/TreeDead2.fbx    |   Bin 0 -> 14332 bytes
 .../SimpleLowPolyNature/Models/TreeDead2.fbx.meta  |   104 +
 Assets/SimpleLowPolyNature/Models/TreeStump1.fbx   |   Bin 0 -> 17852 bytes
 .../SimpleLowPolyNature/Models/TreeStump1.fbx.meta |   105 +
 Assets/SimpleLowPolyNature/Models/WoodBoat.fbx     |   Bin 0 -> 12300 bytes
 .../SimpleLowPolyNature/Models/WoodBoat.fbx.meta   |   104 +
 Assets/SimpleLowPolyNature/Models/WoodFence1.fbx   |   Bin 0 -> 13708 bytes
 .../SimpleLowPolyNature/Models/WoodFence1.fbx.meta |   104 +
 Assets/SimpleLowPolyNature/Models/WoodFence2.fbx   |   Bin 0 -> 13900 bytes
 .../SimpleLowPolyNature/Models/WoodFence2.fbx.meta |   104 +
 Assets/SimpleLowPolyNature/Prefabs.meta            |     8 +
 Assets/SimpleLowPolyNature/Prefabs/CampFire.prefab |  4817 ++++
 .../Prefabs/CampFire.prefab.meta                   |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Cloud1.prefab   |    79 +
 .../SimpleLowPolyNature/Prefabs/Cloud1.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Cloud2.prefab   |    79 +
 .../SimpleLowPolyNature/Prefabs/Cloud2.prefab.meta |    14 +
 .../Prefabs/Clouds1Layer.prefab                    |  4736 ++++
 .../Prefabs/Clouds1Layer.prefab.meta               |    14 +
 .../Prefabs/Clouds2Layer.prefab                    |  4736 ++++
 .../Prefabs/Clouds2Layer.prefab.meta               |    14 +
 .../Prefabs/FallenBranch.prefab                    |    79 +
 .../Prefabs/FallenBranch.prefab.meta               |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Flower1.prefab  |    80 +
 .../Prefabs/Flower1.prefab.meta                    |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Flower2.prefab  |    80 +
 .../Prefabs/Flower2.prefab.meta                    |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Flower3.prefab  |    80 +
 .../Prefabs/Flower3.prefab.meta                    |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Flower4.prefab  |    80 +
 .../Prefabs/Flower4.prefab.meta                    |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Grass1.prefab   |    79 +
 .../SimpleLowPolyNature/Prefabs/Grass1.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Grass2.prefab   |    79 +
 .../SimpleLowPolyNature/Prefabs/Grass2.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Grass3.prefab   |    79 +
 .../SimpleLowPolyNature/Prefabs/Grass3.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Grass4.prefab   |    79 +
 .../SimpleLowPolyNature/Prefabs/Grass4.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Ivy1.prefab     |    79 +
 .../SimpleLowPolyNature/Prefabs/Ivy1.prefab.meta   |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Ivy2.prefab     |    79 +
 .../SimpleLowPolyNature/Prefabs/Ivy2.prefab.meta   |    14 +
 .../Prefabs/LightingPlant1.prefab                  |    80 +
 .../Prefabs/LightingPlant1.prefab.meta             |    14 +
 .../Prefabs/LightingPlant2.prefab                  |    80 +
 .../Prefabs/LightingPlant2.prefab.meta             |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Log.prefab      |    95 +
 Assets/SimpleLowPolyNature/Prefabs/Log.prefab.meta |    14 +
 .../SimpleLowPolyNature/Prefabs/Mushroom1.prefab   |    80 +
 .../Prefabs/Mushroom1.prefab.meta                  |    14 +
 .../SimpleLowPolyNature/Prefabs/Mushroom2.prefab   |    80 +
 .../Prefabs/Mushroom2.prefab.meta                  |    14 +
 .../SimpleLowPolyNature/Prefabs/Mushroom3.prefab   |    80 +
 .../Prefabs/Mushroom3.prefab.meta                  |    14 +
 .../Prefabs/MushroomLarge.prefab                   |    95 +
 .../Prefabs/MushroomLarge.prefab.meta              |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Paddle.prefab   |    79 +
 .../SimpleLowPolyNature/Prefabs/Paddle.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/PlantEx1.prefab |    79 +
 .../Prefabs/PlantEx1.prefab.meta                   |    14 +
 Assets/SimpleLowPolyNature/Prefabs/PlantEx2.prefab |    79 +
 .../Prefabs/PlantEx2.prefab.meta                   |    14 +
 Assets/SimpleLowPolyNature/Prefabs/PlantEx3.prefab |    79 +
 .../Prefabs/PlantEx3.prefab.meta                   |    14 +
 Assets/SimpleLowPolyNature/Prefabs/PlantEx4.prefab |    80 +
 .../Prefabs/PlantEx4.prefab.meta                   |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock1.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock1.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock10.prefab   |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock10.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock11.prefab   |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock11.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock12.prefab   |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock12.prefab.meta |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock2.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock2.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock3.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock3.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock4.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock4.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock5.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock5.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock6.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock6.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock7.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock7.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock8.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock8.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Rock9.prefab    |    94 +
 .../SimpleLowPolyNature/Prefabs/Rock9.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Tent.prefab     |    80 +
 .../SimpleLowPolyNature/Prefabs/Tent.prefab.meta   |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Tree1.prefab    |    95 +
 .../SimpleLowPolyNature/Prefabs/Tree1.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Tree2.prefab    |    95 +
 .../SimpleLowPolyNature/Prefabs/Tree2.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Tree3.prefab    |    96 +
 .../SimpleLowPolyNature/Prefabs/Tree3.prefab.meta  |    14 +
 .../SimpleLowPolyNature/Prefabs/TreeDead1.prefab   |    94 +
 .../Prefabs/TreeDead1.prefab.meta                  |    14 +
 .../SimpleLowPolyNature/Prefabs/TreeDead2.prefab   |    94 +
 .../Prefabs/TreeDead2.prefab.meta                  |    14 +
 .../SimpleLowPolyNature/Prefabs/TreePink1.prefab   |    95 +
 .../Prefabs/TreePink1.prefab.meta                  |    14 +
 .../SimpleLowPolyNature/Prefabs/TreePink3.prefab   |    96 +
 .../Prefabs/TreePink3.prefab.meta                  |    14 +
 .../SimpleLowPolyNature/Prefabs/TreeStump.prefab   |    95 +
 .../Prefabs/TreeStump.prefab.meta                  |    14 +
 .../SimpleLowPolyNature/Prefabs/TreeYellow1.prefab |    95 +
 .../Prefabs/TreeYellow1.prefab.meta                |    14 +
 .../SimpleLowPolyNature/Prefabs/TreeYellow3.prefab |    96 +
 .../Prefabs/TreeYellow3.prefab.meta                |    14 +
 Assets/SimpleLowPolyNature/Prefabs/Water.prefab    |    79 +
 .../SimpleLowPolyNature/Prefabs/Water.prefab.meta  |    14 +
 Assets/SimpleLowPolyNature/Prefabs/WoodBoat.prefab |    79 +
 .../Prefabs/WoodBoat.prefab.meta                   |    14 +
 .../SimpleLowPolyNature/Prefabs/WoodFence1.prefab  |    93 +
 .../Prefabs/WoodFence1.prefab.meta                 |    14 +
 .../SimpleLowPolyNature/Prefabs/WoodFence2.prefab  |    93 +
 .../Prefabs/WoodFence2.prefab.meta                 |    14 +
 Assets/SimpleLowPolyNature/Readme.txt              |     5 +
 Assets/SimpleLowPolyNature/Readme.txt.meta         |    14 +
 Assets/SimpleLowPolyNature/Scenes.meta             |     8 +
 Assets/SimpleLowPolyNature/Scenes/DemoDay.meta     |     8 +
 Assets/SimpleLowPolyNature/Scenes/DemoDay.unity    | 18363 ++++++++++++++
 .../SimpleLowPolyNature/Scenes/DemoDay.unity.meta  |    14 +
 Assets/SimpleLowPolyNature/Scenes/DemoNight.meta   |     8 +
 Assets/SimpleLowPolyNature/Scenes/DemoNight.unity  | 18016 ++++++++++++++
 .../Scenes/DemoNight.unity.meta                    |    14 +
 .../SimpleLowPolyNature/Scenes/PrefabsScene.meta   |     8 +
 .../SimpleLowPolyNature/Scenes/PrefabsScene.unity  |  4403 ++++
 .../Scenes/PrefabsScene.unity.meta                 |    14 +
 .../Scenes/PrefabsScene/Lightmap-1_comp_dir.png    |   Bin 0 -> 15998 bytes
 .../PrefabsScene/Lightmap-1_comp_dir.png.meta      |    95 +
 .../Scenes/PrefabsScene/Lightmap-1_comp_light.exr  |   Bin 0 -> 58484 bytes
 .../PrefabsScene/Lightmap-1_comp_light.exr.meta    |    95 +
 .../SimpleLowPolyNature/Scenes/SceneDemoAsset.meta |     8 +
 .../Scenes/SceneDemoAsset/LowpolyTerrain.prefab    |    94 +
 .../SceneDemoAsset/LowpolyTerrain.prefab.meta      |    14 +
 Assets/SimpleLowPolyNature/Shaders.meta            |     8 +
 .../SimpleLowPolyNature/Shaders/SimpleWater.shader |   255 +
 .../Shaders/SimpleWater.shader.meta                |    16 +
 Assets/TextMesh Pro.meta                           |     8 +
 Assets/TextMesh Pro/Fonts.meta                     |     8 +
 Assets/TextMesh Pro/Fonts/LiberationSans - OFL.txt |    46 +
 .../Fonts/LiberationSans - OFL.txt.meta            |     8 +
 Assets/TextMesh Pro/Fonts/LiberationSans.ttf       |   Bin 0 -> 350200 bytes
 Assets/TextMesh Pro/Fonts/LiberationSans.ttf.meta  |    19 +
 Assets/TextMesh Pro/Resources.meta                 |     8 +
 .../TextMesh Pro/Resources/Fonts & Materials.meta  |     9 +
 .../LiberationSans SDF - Drop Shadow.mat           |   106 +
 .../LiberationSans SDF - Drop Shadow.mat.meta      |     8 +
 .../LiberationSans SDF - Fallback.asset            |   348 +
 .../LiberationSans SDF - Fallback.asset.meta       |     8 +
 .../LiberationSans SDF - Outline.mat               |   104 +
 .../LiberationSans SDF - Outline.mat.meta          |     8 +
 .../Fonts & Materials/LiberationSans SDF.asset     |  8096 +++++++
 .../LiberationSans SDF.asset.meta                  |     8 +
 .../LineBreaking Following Characters.txt          |     1 +
 .../LineBreaking Following Characters.txt.meta     |     8 +
 .../Resources/LineBreaking Leading Characters.txt  |     1 +
 .../LineBreaking Leading Characters.txt.meta       |     8 +
 Assets/TextMesh Pro/Resources/Sprite Assets.meta   |     9 +
 .../Resources/Sprite Assets/EmojiOne.asset         |   659 +
 .../Resources/Sprite Assets/EmojiOne.asset.meta    |     8 +
 Assets/TextMesh Pro/Resources/Style Sheets.meta    |     9 +
 .../Style Sheets/Default Style Sheet.asset         |    81 +
 .../Style Sheets/Default Style Sheet.asset.meta    |     8 +
 Assets/TextMesh Pro/Resources/TMP Settings.asset   |    52 +
 .../TextMesh Pro/Resources/TMP Settings.asset.meta |     8 +
 Assets/TextMesh Pro/Shaders.meta                   |     8 +
 Assets/TextMesh Pro/Shaders/SDFFunctions.hlsl      |   178 +
 Assets/TextMesh Pro/Shaders/SDFFunctions.hlsl.meta |    10 +
 .../Shaders/TMP_Bitmap-Custom-Atlas.shader         |   145 +
 .../Shaders/TMP_Bitmap-Custom-Atlas.shader.meta    |     9 +
 .../TextMesh Pro/Shaders/TMP_Bitmap-Mobile.shader  |   155 +
 .../Shaders/TMP_Bitmap-Mobile.shader.meta          |     9 +
 Assets/TextMesh Pro/Shaders/TMP_Bitmap.shader      |   145 +
 Assets/TextMesh Pro/Shaders/TMP_Bitmap.shader.meta |     9 +
 Assets/TextMesh Pro/Shaders/TMP_SDF Overlay.shader |   326 +
 .../Shaders/TMP_SDF Overlay.shader.meta            |     9 +
 Assets/TextMesh Pro/Shaders/TMP_SDF SSD.shader     |   321 +
 .../TextMesh Pro/Shaders/TMP_SDF SSD.shader.meta   |     9 +
 .../Shaders/TMP_SDF-HDRP LIT.shadergraph           | 12074 +++++++++
 .../Shaders/TMP_SDF-HDRP LIT.shadergraph.meta      |    10 +
 .../Shaders/TMP_SDF-HDRP UNLIT.shadergraph         | 11759 +++++++++
 .../Shaders/TMP_SDF-HDRP UNLIT.shadergraph.meta    |    10 +
 .../Shaders/TMP_SDF-Mobile Masking.shader          |   258 +
 .../Shaders/TMP_SDF-Mobile Masking.shader.meta     |     9 +
 .../Shaders/TMP_SDF-Mobile Overlay.shader          |   252 +
 .../Shaders/TMP_SDF-Mobile Overlay.shader.meta     |     9 +
 .../TextMesh Pro/Shaders/TMP_SDF-Mobile SSD.shader |   106 +
 .../Shaders/TMP_SDF-Mobile SSD.shader.meta         |     9 +
 .../Shaders/TMP_SDF-Mobile-2-Pass.shader           |   389 +
 .../Shaders/TMP_SDF-Mobile-2-Pass.shader.meta      |     9 +
 Assets/TextMesh Pro/Shaders/TMP_SDF-Mobile.shader  |   250 +
 .../Shaders/TMP_SDF-Mobile.shader.meta             |     9 +
 .../Shaders/TMP_SDF-Surface-Mobile.shader          |   139 +
 .../Shaders/TMP_SDF-Surface-Mobile.shader.meta     |     9 +
 Assets/TextMesh Pro/Shaders/TMP_SDF-Surface.shader |   159 +
 .../Shaders/TMP_SDF-Surface.shader.meta            |     9 +
 .../Shaders/TMP_SDF-URP Lit.shadergraph            | 11932 +++++++++
 .../Shaders/TMP_SDF-URP Lit.shadergraph.meta       |    10 +
 .../Shaders/TMP_SDF-URP Unlit.shadergraph          | 11629 +++++++++
 .../Shaders/TMP_SDF-URP Unlit.shadergraph.meta     |    10 +
 Assets/TextMesh Pro/Shaders/TMP_SDF.shader         |   326 +
 Assets/TextMesh Pro/Shaders/TMP_SDF.shader.meta    |     9 +
 Assets/TextMesh Pro/Shaders/TMP_Sprite.shader      |   131 +
 Assets/TextMesh Pro/Shaders/TMP_Sprite.shader.meta |     9 +
 Assets/TextMesh Pro/Shaders/TMPro.cginc            |    84 +
 Assets/TextMesh Pro/Shaders/TMPro.cginc.meta       |     9 +
 Assets/TextMesh Pro/Shaders/TMPro_Mobile.cginc     |   165 +
 .../TextMesh Pro/Shaders/TMPro_Mobile.cginc.meta   |     9 +
 Assets/TextMesh Pro/Shaders/TMPro_Properties.cginc |    80 +
 .../Shaders/TMPro_Properties.cginc.meta            |     9 +
 Assets/TextMesh Pro/Shaders/TMPro_Surface.cginc    |    99 +
 .../TextMesh Pro/Shaders/TMPro_Surface.cginc.meta  |     9 +
 Assets/TextMesh Pro/Sprites.meta                   |     8 +
 .../TextMesh Pro/Sprites/EmojiOne Attribution.txt  |     3 +
 .../Sprites/EmojiOne Attribution.txt.meta          |     7 +
 Assets/TextMesh Pro/Sprites/EmojiOne.json          |   156 +
 Assets/TextMesh Pro/Sprites/EmojiOne.json.meta     |     8 +
 Assets/TextMesh Pro/Sprites/EmojiOne.png           |   Bin 0 -> 112319 bytes
 Assets/TextMesh Pro/Sprites/EmojiOne.png.meta      |   431 +
 Assets/_Project/Audio.meta                         |     8 +
 Assets/_Project/Materials.meta                     |     8 +
 .../_Project/Materials/Building_Ghost_Invalid.mat  |   141 +
 .../Materials/Building_Ghost_Invalid.mat.meta      |     8 +
 Assets/_Project/Materials/Building_Ghost_Valid.mat |   141 +
 .../Materials/Building_Ghost_Valid.mat.meta        |     8 +
 Assets/_Project/Materials/Building_Mat.mat         |   137 +
 Assets/_Project/Materials/Building_Mat.mat.meta    |     8 +
 Assets/_Project/Materials/Enemy_Mat.mat            |   137 +
 Assets/_Project/Materials/Enemy_Mat.mat.meta       |     8 +
 Assets/_Project/Materials/Ground_Mat.mat           |   137 +
 Assets/_Project/Materials/Ground_Mat.mat.meta      |     8 +
 Assets/_Project/Materials/Player_Mat.mat           |   137 +
 Assets/_Project/Materials/Player_Mat.mat.meta      |     8 +
 Assets/_Project/Prefabs.meta                       |     8 +
 Assets/_Project/Prefabs/Players/Player.prefab      |   529 +
 Assets/_Project/Prefabs/Players/Player.prefab.meta |     7 +
 Assets/_Project/Scenes.meta                        |     8 +
 Assets/_Project/Scenes/ColonyScene.unity           |  1983 ++
 Assets/_Project/Scenes/ColonyScene.unity.meta      |     7 +
 Assets/_Project/Scenes/MainMenu.unity              |  1292 +
 Assets/_Project/Scenes/MainMenu.unity.meta         |     7 +
 Assets/_Project/Scenes/RaidScene.unity             |   495 +
 Assets/_Project/Scenes/RaidScene.unity.meta        |     7 +
 Assets/_Project/Scripts.meta                       |     8 +
 Assets/_Project/Scripts/Editor/BuildScript.cs      |   302 +
 Assets/_Project/Scripts/Editor/PrefabGenerator.cs  |   330 +
 Assets/_Project/Scripts/Editor/SceneGenerator.cs   |   395 +
 Assets/_Project/Scripts/Editor/SetupAutomation.cs  |   105 +
 Assets/_Project/Scripts/Utilities/DontDestroy.cs   |     7 +
 .../_Project/Scripts/Utilities/DontDestroy.cs.meta |     2 +
 .../_Project/Scripts/Utilities/QuickSetupHelper.cs |    12 +-
 .../Scripts/Utilities/QuickSetupHelper.cs.meta     |     2 +
 Assets/_Project/Textures.meta                      |     8 +
 ProjectPlanningDocs/7DayHackathon.md               |  2529 +-
 ProjectPlanningDocs/BuildAutomationPlan.md         |   145 +
 ProjectPlanningDocs/Day0.md                        |  2072 +-
 .../DevelopmentOverviewSpaceColonyRPG.md           |  2510 +-
 ProjectSettings/EditorBuildSettings.asset          |    10 +-
 ProjectSettings/GraphicsSettings.asset             |     9 +-
 ProjectSettings/ProjectSettings.asset              |     5 +-
 ProjectSettings/TagManager.asset                   |     1 +
 build.bat                                          |   108 +
 build.sh                                           |   126 +
 3492 files changed, 485413 insertions(+), 5218 deletions(-)

## Key Changes
--- /dev/null
+++ b/.ai-templates/NetworkedClass.template
@@ -0,0 +1,217 @@
+// Template: Networked MonoBehaviour
+// Usage: "Create NetworkedEnemy using NetworkedClass template"
+// Replace: [FEATURE], [CLASSNAME], [DESCRIPTION]
+using System.Collections;
+using System.Collections.Generic;
+using UnityEngine;
+using Mirror;
+namespace SpaceColony.[FEATURE]
+{
+    /// <summary>
+    /// [DESCRIPTION]
+    /// Networked: Yes
+    /// Authority: Server
+    /// </summary>
+    public class [CLASSNAME] : NetworkBehaviour
+    {
+        #region Constants
+        // Add constants here
+        #endregion
+        #region Private Fields
+        [Header("References")]
+        [SerializeField] private GameObject examplePrefab;
+        
+        [Header("Settings")]
+        [SerializeField] private float exampleValue = 1f;
+        
+        private bool _isInitialized = false;

## Staged Changes Summary
- Files changed: 3492
- Insertions: 485413 insertion
- Deletions: 5218 deletion
